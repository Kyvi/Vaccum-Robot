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
	/// Some Graphics utilities :
	/// startX : horizontal position of room 0 's Vaccum
	/// startY : vertical position of room 0 's Vaccum
	/// nextX : horizontal distance between each room
	/// nextY : vertical distance between each room
	/// </summary>
	public float startX = -0.5f;
	public float startY = 1.8f;
	public float nextX = 2.33f;
	public float nextY = 1.47f;

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
		cameraC = environment.GetComponent<CameraController>();

		armC = GetComponent<ArmController>();
		legC = GetComponent<LegController>();
		pipeC = GetComponent<PipeController>();

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
		yield return StartCoroutine(loadPerceipts());
		setRoomScores ();
		setActionPlan ();
		yield return StartCoroutine(executeActionPlan ());
		StartCoroutine(work());

	}

	/// <summary>
	/// Loads the states of the rooms into the vaccum perceipts.
	/// </summary>
	private IEnumerator loadPerceipts(){
		int nbRooms = environmentC.nbRooms;
		perceipts = new int[nbRooms] ;
		for (int i = 0; i < nbRooms; i++){
			yield return cameraC_ActionWait;
			perceipts[i]= cameraC.view(i) ;
		}
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

		int roomGoal = 0;
		int roomGoalScore = roomScores[0];
		for (int i = 1; i < roomScores.Length; i++) {
			if (roomScores [i] > roomGoalScore) {
				roomGoal = i;
				roomGoalScore = roomScores [i];
			}
		}

		int lineR = environmentC.rooms [roomGoal].lineR;
		int columnR = environmentC.rooms [roomGoal].columnR;

		if (lineV > lineR) {
			for (int i = 0; i < lineV - lineR; i++) {
				actionPlan.Add (3);
			}
		}
		if (lineV < lineR) {
			for (int i = 0; i < lineR - lineV; i++) {
				actionPlan.Add (1);
			}
		}
		if (columnV > columnR) {
			for (int i = 0; i < columnV - columnR; i++) {
				actionPlan.Add (2);
			}
		}
		if (columnV < columnR) {
			for (int i = 0; i < columnR - columnV; i++) {
				actionPlan.Add (0);
			}
		}


		int perceptState = perceipts[roomGoal];
		switch (perceptState) {
		case 0:
			break;
		case 1:
			actionPlan.Add (4);
			break;
		case 2:
			actionPlan.Add (5);
			break;
		case 3:
			actionPlan.Add (5);
			actionPlan.Add (4);
			break;
		}

	}

	/// <summary>
	/// Executes the action plan :
	/// Solve each action from ActionPlan arrayList.
	/// </summary>
	private IEnumerator executeActionPlan(){
		//Version 1
			while (actionPlan.Count != 0) {
				int action = (int)actionPlan [0];
				switch (action) {
				case 0:
					yield return legC_ActionWait;
					legC.move (0);
					break;
				case 1:
					yield return legC_ActionWait;
					legC.move (1);
					break;
				case 2:
					yield return legC_ActionWait;
					legC.move (2);
					break;
				case 3:
					yield return legC_ActionWait;
					legC.move (3);
					break;
				case 4:
					yield return pipeC_ActionWait;
					pipeC.vaccumUp ();
					break;
				case 5:
					yield return armC_ActionWait;
					armC.take ();
					break;
				}
				actionPlan.RemoveAt (0);
			}
	}
		
	
}
