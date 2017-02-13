using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaccumController : MonoBehaviour {

	/// <summary>
	/// UI text elements.
	/// </summary>
	public Text depthText;
	public Text nbMovesText;
	public Text nbVaccumText;
	public Text nbTakeText;

	/// <summary>
	/// The graph and the depth where the vaccum explores the graph.
	/// </summary>
	public Graph graph;
	public int depth = 1;

	/// <summary>
	/// performanceCheckFrequence : The number of loop of the coroutine this instance goes through before checking its performance.
	/// loopLeft : the number of loop left until this instance goes through before checking its performance.
	/// </summary>
	public int performanceCheckFrequence = 5;
	private int loopLeft;

	/// <summary>
	/// isMesuresFull : have all the mesures been made.
	/// currentMesure : the position of currentMesure in the performanceMesures array.
	/// nbMesures : the number of Mesures taken.
	/// performanceMesures : The previous performance mesures.
	/// </summary>
	private bool isMesuresFull = false;
	private int positionCurrentMesure = 0;
	public int nbMesures = 7; // 7 is the max here, don't try 8, cause at depth = 8, the graph takes to much time to be explored.
	private float[] performanceMesures;


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
	/// nbScores refers to the number of elements in the actionScores[] Array
	/// 0 -> Move 
	/// 1 -> VaccumUpDust
	/// 2 -> TakeJewel
	/// 3 -> VaccumUpJewel
	/// The scores of the different actions.
	/// </summary>
	public int nbScores = 4;
	public int[] actionScores;

	/// <summary>
	/// The action plan.
	/// -1 : Do nothing
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

	/// <summary>
	/// Some informations
	/// nbMoves : number of moves made by the vaccum
	/// nbVaccum : number of vaccuming action performed
	/// nbTake : number of taking action performed
	/// </summary>
	private int nbMoves = 0;
	private int nbVaccum = 0;
	private int nbTake = 0;

	/// <summary>
	/// Initializes some parameters of the vaccum.
	/// </summary>
	void Start(){
		
		environmentC = environment.GetComponent<EnvironmentController>();
		cameraC = environment.GetComponent<CameraController>();

		armC = GetComponent<ArmController>();
		legC = GetComponent<LegController>();
		pipeC = GetComponent<PipeController>();

		loopLeft = performanceCheckFrequence;
		performanceMesures = new float[nbMesures];

		int nbRooms = environmentC.nbRooms;
		perceipts = new int[nbRooms];
		roomScores = new int[nbRooms];

		actionScores = new int[nbScores];
		actionScores[0] = legC.actionScore;
		actionScores[1] = pipeC.actionScore;
		actionScores[2] = armC.actionScore;
		actionScores[3] = pipeC.stealingJewelScore;

		cameraC_ActionWait = new WaitForSeconds (cameraC.ActionTime);
		armC_ActionWait = new WaitForSeconds (armC.ActionTime);
		legC_ActionWait = new WaitForSeconds (legC.ActionTime);
		pipeC_ActionWait = new WaitForSeconds (pipeC.ActionTime);

		StartCoroutine(work()); 
		InvokeRepeating ("printGlobalInfo", 0, 1);
	}

	public void printGlobalInfo(){
		depthText.text = "Current depth : " + depth;
		nbMovesText.text = "Moves made : " + nbMoves;
		nbVaccumText.text = "Vaccuming performed : " + nbVaccum;
		nbTakeText.text = "Taking performed : " + nbTake;
	}

	/// <summary>
	/// Main method of the Vaccum where it does its work following BDI method
	/// </summary>
	private IEnumerator work()
	{
		// Performance mesure update 
		if (!isMesuresFull) {
			if (loopLeft == 0) {
				performanceUpdate ();
				loopLeft = performanceCheckFrequence;
			} else {
				loopLeft--;
			}
		}

		// Beliefs
		yield return StartCoroutine(loadPerceipts());
		Node root = new Node (-1, position, lineV, columnV,  environmentC.nbRooms, perceipts, 0, null, 0, nbScores, actionScores ); // root Node
		graph = new Graph (root,depth); // Graph from actual beliefs of AI

		// Desire
		setActionPlan ();

		// Intention
		yield return StartCoroutine(executeActionPlan ());

		// Repeat this routine again
		StartCoroutine(work());

	}

	/// <summary>
	/// Updates the perfomance of the Vaccum
	/// </summary>
	public void performanceUpdate(){

		//Updates the depth where the vaccum explores the graph and the performance mesure Array.
		float newMesure = environmentC.performanceMesure; // memorize the current performanceMesure
		environmentC.performanceReset (); // Reset the time and score

		// Updates the performance mesure Array
		performanceMesures [positionCurrentMesure] = newMesure;
		positionCurrentMesure++; 
		depth++; //Updates the depth where the vaccum explores the graph 


		// Determines the best PerformanceMesure
		if (positionCurrentMesure == nbMesures) { // checks if the performance mesure Array is full
			isMesuresFull = true; // the array is full
			int positionBestPerformance = 0; // initializes the position of the best performance
			float bestPerformance = performanceMesures [0]; // initializes the best performance 

			// Finds the best Performance
			for (int i = 0; i < nbMesures; i++) {
				if (performanceMesures [i] > bestPerformance) {
					bestPerformance = performanceMesures [i]; // updates the best performance
					positionBestPerformance = i; // updates the best performance position
				}
			}
			depth = positionBestPerformance - 1; // updates the best depth 
		}

	}

	/// <summary>
	/// Loads the states of the rooms into the vaccum perceipts.
	/// </summary>
	private IEnumerator loadPerceipts(){
		for (int i = 0; i < perceipts.Length; i++){
			yield return cameraC_ActionWait;
			perceipts[i]= cameraC.view(i) ;
		}
	}

	/// <summary>
	/// Sets the action plan.
	/// </summary>
	public void setActionPlan(){
		
		int bestScore = 0; // Initialize the best score of all the nodes
		Node currentNode = graph.graphNodes [0]; // Initialize the current Node
		Node goalNode = currentNode; // Initialize the goal Node
		int compteur = 0; // Initialize the loop count increment

		while (compteur < graph.graphNodes.Count && currentNode.depth <= depth) { // Graph exploration

			currentNode = graph.graphNodes [compteur];  // gets the current Node
			int currentNodeScore = currentNode.score; // reference to the current Node Score

			if (currentNodeScore >= bestScore) { 
				bestScore = currentNodeScore; // Sets the bestScore
				goalNode = currentNode; // Sets the goalNode
			}

			compteur++;
		} // End of graph exploration

		Node auxNode = goalNode; // initialize the transition Node

		// builds the action plan by going back to the root
		for (int i=0; i<depth; i++){ 
			actionPlan.Insert(0, auxNode.type); 
			auxNode = auxNode.father;
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
				case -1:
					actionPlan.RemoveAt (0);
					break;
				case 0:
					yield return legC_ActionWait;
					legC.move (0);
					nbMoves++;
					actionPlan.RemoveAt (0);
					break;
				case 1:
					yield return legC_ActionWait;
					legC.move (1);
					nbMoves++;
					actionPlan.RemoveAt (0);
					break;
				case 2:
					yield return legC_ActionWait;
					legC.move (2);
					nbMoves++;
					actionPlan.RemoveAt (0);
					break;
				case 3:
					yield return legC_ActionWait;
					legC.move (3);
					nbMoves++;
					actionPlan.RemoveAt (0);
					break;
				case 4:
					yield return cameraC_ActionWait;
					int roomState = cameraC.view (position);
					if (roomState == 1) {
						yield return pipeC_ActionWait;
						pipeC.vaccumUp ();
						nbVaccum++;
						actionPlan.RemoveAt (0);
					} else {
						actionPlan.Clear ();
					}
					break;
				case 5:
					yield return armC_ActionWait;
					armC.take ();
					nbTake++;
					actionPlan.RemoveAt (0);
					break;
				}
			}
	}
		
	
}
