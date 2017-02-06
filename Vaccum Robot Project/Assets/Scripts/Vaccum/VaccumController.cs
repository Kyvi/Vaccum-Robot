using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccumController : MonoBehaviour {

	/// <summary>
	/// The position of the vaccum.
	/// </summary>
	public int position=0 ;    

	/// <summary>
	/// line and column of the vaccum : graphic position
	/// </summary>
	public int lineV = 0 ;        
	public int columnV = 0 ; 

	/// <summary>
	/// The perceipts contains the states of the rooms that the vaccum thinks.
	/// </summary>
	public int[] perceipts;          

	/// <summary>
	/// The room scores.
	/// A high score means a high priority for the Vaccum.
	/// </summary>
	public int[] roomScores;

	/// <summary>
	/// The action plan.
	/// 0 : Go right
	/// 1 : Go down
	/// 2 : Go left
	/// 3 : Go up
	/// 4 : vaccum up dust
	/// 5 : take jewel
	/// </summary>
	public ArrayList actionPlan = new ArrayList();

	/// <summary>
	/// The environment.
	/// </summary>
	public GameObject environment;         

	/// <summary>
	/// Reference to the actual EnvironmentController, CameraController, ArmController, LegController and PipeController
	/// </summary>
	private EnvironmentController environmentC;
	private CameraController cameraC;
	private ArmController armC;
	private LegController legC;
	private PipeController pipeC;

	/// <summary>
	/// The times needed for the part to do their actions.
	/// </summary>
	private WaitForSeconds cameraC_ActionWait;
	private WaitForSeconds armC_ActionWait;
	private WaitForSeconds legC_ActionWait;
	private WaitForSeconds pipeC_ActionWait;

	void Start(){
		
		environmentC = environment.GetComponent<EnvironmentController>();
		cameraC = environment.GetComponentInChildren<CameraController>();

		armC = GetComponentInChildren<ArmController>();
		legC = GetComponentInChildren<LegController>();
		pipeC = GetComponentInChildren<PipeController>();

		int nbRooms = environmentC.nbRooms;
		perceipts = new int[nbRooms];
		roomScores = new int[nbRooms];

		cameraC_ActionWait = new WaitForSeconds (cameraC.ActionTime);
		armC_ActionWait = new WaitForSeconds (armC.ActionTime);
		legC_ActionWait = new WaitForSeconds (legC.ActionTime);
		pipeC_ActionWait = new WaitForSeconds (pipeC.ActionTime);

		StartCoroutine(work()); 

	}

	/// <summary>
	/// Main method of the Vaccum where it does its work.
	/// </summary>
	private IEnumerator work()
	{
		loadPerceipts();
		setRoomScores ();
		setActionPlan ();
		executeActionPlan ();
		yield return work ();

	}

	/// <summary>
	/// Loads the states of the rooms into the vaccum perceipts.
	/// </summary>
	public void loadPerceipts(){
		int nbRooms = environmentC.nbRooms;
		perceipts = new int[nbRooms] ;
		for (int i = 0; i < nbRooms; i++){
			StartCoroutine(simulateCamera());
			perceipts[i]= cameraC.view(i) ;
		}
	}

	/// <summary>
	/// Simulates the action time of the camera
	/// </summary>
	private IEnumerator simulateCamera()
	{
		yield return cameraC_ActionWait;
	}
		
	/// <summary>
	/// Sets the room scores.
	/// </summary>
	public void setRoomScores(){
		int nbRooms = environmentC.nbRooms;

		for (int i = 0; i < nbRooms; i++){
			int distance = environmentC.distanceTable [position] [i];
			int distanceScore = distance * legC.actionScore;

			int state = environmentC.rooms[i].state;
			int stateScore = 0;
			int vaccumUpScore = pipeC.actionScore;
			int takeScore = armC.actionScore;
			switch (state) {
			case 0:
				break;
			case 1:
				stateScore = vaccumUpScore;
				break;
			case 2:
				stateScore = takeScore;
				break;
			case 3:
				stateScore = vaccumUpScore+takeScore;
				break;
			}
			roomScores [i] = distanceScore + stateScore;
		}
	}

	/// <summary>
	/// Sets the action plan.
	/// </summary>
	public void setActionPlan(){
		//TODO (create an arrayList with actions according to exploration trees algorithms)
	}

	/// <summary>
	/// Executes the action plan :
	/// Solve each action from ActionPlan arrayList.
	/// </summary>
	public void executeActionPlan(){
		//Version 1
		while (actionPlan.Count != 0) {
			int action = (int) actionPlan [0];
			switch (action) {
			case 0:
				StartCoroutine (simulateLeg ());
				legC.move (0);
				break;
			case 1:
				StartCoroutine (simulateLeg ());
				legC.move (1);
				break;
			case 2:
				StartCoroutine (simulateLeg ());
				legC.move (2);
				break;
			case 3:
				StartCoroutine (simulateLeg ());
				legC.move (3);
				break;
			case 4:
				StartCoroutine (simulatePipe ());
				pipeC.vaccumUp ();
				break;
			case 5:
				StartCoroutine (simulateArm ());
				armC.take ();
				break;
			}
			actionPlan.RemoveAt (0);
		}
	
	}

	/// <summary>
	/// Simulates the action time of the arm
	/// </summary>
	private IEnumerator simulateArm()
	{
		yield return armC_ActionWait;
	}

	/// <summary>
	/// Simulates the action time of the leg
	/// </summary>
	private IEnumerator simulateLeg()
	{
		yield return legC_ActionWait;
	}

	/// <summary>
	/// Simulates the action time of the camera
	/// </summary>
	private IEnumerator simulatePipe()
	{
		yield return pipeC_ActionWait;
	}
		
	
}
