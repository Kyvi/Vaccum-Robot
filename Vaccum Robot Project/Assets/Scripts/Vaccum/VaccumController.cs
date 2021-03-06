﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaccumController : MonoBehaviour {

	/********************************************************/
	/************** UI ELEMENTS *****************************/
	/********************************************************/

	/// <summary>
	/// Some Text informations about the depth where the instance explore, number of actions to be executed and the actions of the vaccum.
	/// </summary>
	public Text depthText;
	public Text nbActionText;
	public Text nbMovesText;
	public Text nbVaccumText;
	public Text nbTakeText;

	/// <summary>
	/// Some informations about the different actions
	/// nbMoves : number of moves made by the vaccum
	/// nbVaccum : number of vaccuming action performed
	/// nbTake : number of taking action performed
	/// </summary>
	public int nbMoves = 0;
	public int nbVaccum = 0;
	public int nbTake = 0;

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

	/********************************************************/
	/************** PERFFORMANCE MEASURES *******************/
	/********************************************************/

	/// <summary>
	/// nbActionExecuted : The number of actions executed from the action plan before executing the work function again
	/// performanceCheckFrequence : The number of loop of the coroutine this instance goes through before checking its performance.
	/// loopLeft : the number of loop left until this instance goes through before checking its performance.
	/// </summary>
	public int nbActionExecuted = 1;
	public int performanceCheckFrequence = 10;
	private int loopLeft;

	/// <summary>
	/// isMesuresFull : have all the mesures been made.
	/// currentMesure : the position of currentMesure in the performanceMesures array.
	/// nbMesures : the number of Mesures taken.
	/// performanceMesures : The previous performance mesures.
	/// </summary>
	private bool isMesuresFull = false;
	private int positionCurrentMesure = 0;
	public int nbMesures = 6; // 7 is the max here, don't try 8, cause at depth = 8, the graph takes to much time to be explored.
	private List<float> performanceMesures;

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

	/********************************************************/
	/**************** ENVIRONMENT ***************************/
	/********************************************************/

	/// <summary>
	/// The environment.
	/// </summary>
	public GameObject environment; 

	/// <summary>
	/// Reference to the actual EnvironmentController
	/// </summary>
	private EnvironmentController environmentC;

	/// <summary>
	/// The depth where the vaccum explores the graph.
	/// </summary>
	public int depth = 1;

	/// <summary>
	/// The position of the vaccum in the environment.
	/// </summary>
	public int position=0 ;    

	/// <summary>
	/// line and column of the vaccum : graphic position.
	/// </summary>
	public int lineV = 0 ;        
	public int columnV = 0 ; 

	/// <summary>
	/// The perceipts contains the states of the rooms that the vaccum loads with the camera.
	/// </summary>
	public int[] perceipts;          

	/********************************************************/
	/************** SENSORS AND EFFECTORS *******************/
	/********************************************************/
 
	/// <summary>
	/// Reference to the actual CameraController, ArmController, LegController and PipeController
	/// </summary>
	private CameraController cameraC;
	private ArmController armC;
	private LegController legC;
	private PipeController pipeC;

	/// <summary>
	/// The times needed for the sensors and effectors to do their actions.
	/// </summary>
	private WaitForSeconds cameraC_ActionWait;
	private WaitForSeconds armC_ActionWait;
	private WaitForSeconds legC_ActionWait;
	private WaitForSeconds pipeC_ActionWait;


	/// <summary>
	/// Initializes some parameters of the vaccum and launch some methods.
	/// </summary>
	void Start(){
		
		// Gets the environment, sensors and effectors
		environmentC = environment.GetComponent<EnvironmentController>();
		cameraC = environment.GetComponent<CameraController>();

		armC = GetComponent<ArmController>();
		legC = GetComponent<LegController>();
		pipeC = GetComponent<PipeController>();

		cameraC_ActionWait = new WaitForSeconds (cameraC.ActionTime);
		armC_ActionWait = new WaitForSeconds (armC.ActionTime);
		legC_ActionWait = new WaitForSeconds (legC.ActionTime);
		pipeC_ActionWait = new WaitForSeconds (pipeC.ActionTime);

		int nbRooms = environmentC.nbRooms;
		perceipts = new int[nbRooms];

		// Initialize some values needed for Performance Measures
		loopLeft = performanceCheckFrequence;
		performanceMesures = new List<float>();

		actionScores = new int[nbScores];
		actionScores[0] = legC.actionScore;
		actionScores[1] = pipeC.actionScore;
		actionScores[2] = armC.actionScore;
		actionScores[3] = pipeC.stealingJewelScore;

		// Launch some methods. 
		StartCoroutine(work()); // Launch the action function of this instance
		InvokeRepeating ("printGlobalInfo", 0, 1); // Do "printGlobalInfo()" every second.
	}

	/// <summary>
	/// Updates the UI text
	/// </summary>
	public void printGlobalInfo(){
		depthText.text = "Current depth : " + depth;
		nbActionText.text = "Current number of executed actions : " + nbActionExecuted;
		nbMovesText.text = "Moves made : " + nbMoves;
		nbVaccumText.text = "Vaccuming performed : " + nbVaccum;
		nbTakeText.text = "Taking performed : " + nbTake;
	}

	/// <summary>
	/// Action function of the Vaccum where it does its work following BDI method
	/// </summary>
	private IEnumerator work()
	{
		// Performance measure update 
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
		float newMesure = environmentC.performanceMesure; // memorize the current Performance Measure
		environmentC.performanceReset (); // Reset the time and score

		// Updates the performance measure List
		performanceMesures.Add(newMesure);
		positionCurrentMesure++; 
		if (depth == nbActionExecuted) {
			depth++; //Updates the depth where the vaccum explores the graph 
			nbActionExecuted = 1;
		} else {
			nbActionExecuted++; //Increases the nb of actions done during executions
		}


		// Determines the best Performance measure
		int nbTot = (nbMesures*(nbMesures+1))/2;
		if (positionCurrentMesure == nbTot) { // checks if the performance measure Array is full
			isMesuresFull = true; // the array is full
			int positionBestPerformance = 0; // initializes the position of the best performance
			float bestPerformance = performanceMesures [0]; // initializes the best performance 

			// Finds the best Performance
			for (int i = 0; i < nbTot; i++) {
				if (performanceMesures [i] > bestPerformance) {
					bestPerformance = performanceMesures [i]; // updates the best performance
					positionBestPerformance = i; // updates the best performance position
				}
			}

			int[] depthArray = new int[nbTot];
			int aux = 0;
			int aux2 = 1;
			for (int i = 0; i < depth-1; i++) {
				for (int j = aux; j < aux+1+i; j++) {
					depthArray [j] = aux2;
				}
				aux2++;
				aux = aux + 1 + i;
			}
			depth = depthArray [positionBestPerformance]; // updates the best depth 


			int[] nbActionArray = new int[nbTot];
			int aux3 = 0;
			for (int i = 0; i < depth; i++) {
				for (int j = aux3; j < aux3+1+i; j++) {
					nbActionArray[j] = j-aux3+1;
					Debug.Log (j);
				}
				aux3 = aux3 + 1 + i;
			}
			nbActionExecuted = nbActionArray [positionBestPerformance]; // Updates the number of actions executed from the action plan
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

		// Graph construction
		Node root = new Node (-1, position, lineV, columnV,  environmentC.nbRooms, perceipts, 0, null, 0, nbScores, actionScores ); // root Node
		Graph graph = new Graph (root,depth); // Graph from actual beliefs of AI

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
	/// Solves each action from ActionPlan arrayList one by one.
	/// </summary>
	private IEnumerator executeActionPlan(){
		int nbActions = nbActionExecuted;
		while (actionPlan.Count != 0 && nbActions != 0) {
				int action = (int)actionPlan [0];
				switch (action) {
				case -1: // Nothing
					actionPlan.RemoveAt (0); // Remove the action from the action plan
					break;
				case 0: // Move right 
					yield return legC_ActionWait; // Simulates leg action
					legC.move (0); // Executes leg action
					actionPlan.RemoveAt (0);
					break;
				case 1: // Move down
					yield return legC_ActionWait;
					legC.move (1);
					actionPlan.RemoveAt (0);
					break;
				case 2: // Move left
					yield return legC_ActionWait;
					legC.move (2);
					actionPlan.RemoveAt (0);
					break;
				case 3: // Move up
					yield return legC_ActionWait;
					legC.move (3);
					actionPlan.RemoveAt (0);
					break;
				case 4: // Vaccum up
					yield return cameraC_ActionWait;  // Simulates camera action
					int roomState = cameraC.view (position); // Gets the state of the current Vaccum's room
					if (roomState == 1) { // If there is only dust
						yield return pipeC_ActionWait; // Simulates pipe action
						pipeC.vaccumUp (); // Executes pipe action
						actionPlan.RemoveAt (0);
					} else { // Jewel must have appeared during the vaccum execution plan
						actionPlan.Clear (); // Abort the execution of the plan and restart the action function
					}
					break;
				case 5: // Take
					yield return armC_ActionWait; // Simulates arm action
					armC.take (); // Executes arm action
					actionPlan.RemoveAt (0);
					break;
				}
			nbActions--;
			}
	}
		
	
}
