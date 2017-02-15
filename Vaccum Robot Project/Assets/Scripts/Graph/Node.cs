using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node{

	/// <summary>
	/// The identifier of the node, here it's the position of the room its assigned to.
	/// </summary>
	public int id;

	/// <summary>
	/// The score of the Node
	/// </summary>
	public int score;

	/// <summary>
	/// the action of the vaccum on choosing this node :
	/// -1 : nothing
	/// 0 : left
	/// 1 : up
	/// 2 : right
	/// 3 : bottom
	/// 4 : vaccum up
	/// 5 : take
	/// </summary>
	public int type;

	/// <summary>
	/// The line and column of the node according to room positions
	/// </summary>
	public int line;
	public int column;

	/// <summary>
	/// The depth of the node in the graph
	/// </summary>
	public int depth;

	/// <summary>
	/// The father of the node
	/// </summary>
	public Node father;
	/// <summary>
	/// The children of the node
	/// </summary>
	public List<Node> children;

	/// <summary>
	/// nbRooms only refers here to the number of elements in the states[] Array
	/// states : current states of the other actual rooms.
	/// </summary>
	public int nbRooms;
	public int[] states;

	/// <summary>
	/// nbScores refers to the number of elements in the actionScores[] Array
	/// 0 -> Move 
	/// 1 -> VaccumUpDust
	/// 2 -> TakeJewel
	/// 3 -> VaccumUpJewel
	/// The scores of the different actions.
	/// </summary>
	public int nbScores;
	public int[] actionScores;



	/// <summary>
	/// Initializes a new instance of the <see cref="Node"/> class.
	/// </summary>
	/// <param name="type">Type.</param>
	/// <param name="id">Identifier.</param>
	/// <param name="line">Line.</param>
	/// <param name="column">Column.</param>
	/// <param name="nbRooms">Nb rooms.</param>
	/// <param name="states">States.</param>
	/// <param name="depth">Depth.</param>
	/// <param name="father">Father.</param>
	/// <param name="score">Score.</param>
	/// <param name="nbScores">Nb scores.</param>
	/// <param name="actionScores">Action scores.</param>

	public Node(int type, int id, int line, int column, 
		int nbRooms, int[] states, int depth, Node father, int score, int nbScores, int[] actionScores){
		this.type = type;
		this.id = id;
		this.line = line;
		this.column = column;
		this.nbRooms = nbRooms;
		this.states = new int[nbRooms];
		for (int i = 0; i < nbRooms; i++) {
			this.states [i] = states [i];
		}

		this.nbScores= nbScores;
		this.actionScores = new int[nbScores];
		for (int i = 0; i < nbScores; i++) {
			this.actionScores [i] = actionScores [i];
		}

		this.depth = depth;
		this.father = father;
		this.score = score;

		children = new List<Node> ();

	}

	public string toString(){
		return "Informations : " + "type : " + type  + "  id : " + id +  "  score : " + score + "  depth : " + depth;
	}

	/// <summary>
	/// Adds different type of children nodes
	/// </summary>


	public void addVaccumUp(){
		int auxScore = score;
		switch (states [id]) {
		case 0: 
			auxScore -= 1;
			break;
		case 1:
			auxScore  += actionScores [1];
			break;
		case 2:
			auxScore  += actionScores [3];
			break;
		case 3:
			auxScore  = score + actionScores [1] + actionScores [3];
			break;
		}
		children.Add (new Node (4, id, line, column, nbRooms, states, depth+1,this, auxScore , nbScores, actionScores));
	}

	public void addTake(){
		int auxScore = score;
		switch (states [id]) {
		case 0:
			auxScore -= 1;
			break;
		case 1:
			auxScore -= 1;
			break;
		case 2:
			auxScore += actionScores [2];
			break;
		case 3:
			auxScore += actionScores [2];
			break;
		}
		children.Add (new Node (5, id, line, column, nbRooms, states, depth+1,this, auxScore, nbScores, actionScores));
	}

	public void addRight(){
		children.Add (new Node (0, id+1, line, column+1, nbRooms, states, depth+1,this, score+actionScores[0], nbScores, actionScores));
	}

	public void addLeft(){
		children.Add (new Node (2, id-1, line, column-1, nbRooms, states, depth+1,this, score+actionScores[0], nbScores, actionScores));
	}

	public void addTop(){
		children.Add (new Node (3, id-5, line-1, column, nbRooms, states, depth+1,this, score+actionScores[0], nbScores, actionScores));
	}

	public void addBottom(){
		children.Add (new Node (1, id+5, line+1, column, nbRooms, states, depth+1,this, score+actionScores[0], nbScores, actionScores));
	}

	public void addNothing(){
		children.Add(new Node(-1,id,line,column, nbRooms, states, depth+1,this, score, nbScores, actionScores));
	}

	/// <summary>
	/// Creates the children.
	/// </summary>
	public void createChildren(){
		if (type == 4) {
			states [id] = 0;
		}
		if (type == 5) {
			if (states [id] == 3) {
				states [id] = 1;
			} else { if (states [id] == 2) {
					states [id] = 0;
				}
			}
		}

		addVaccumUp ();
		addTake ();

		if (line != 0) {
			addTop ();
		}
		if (line != 4) {
			addBottom ();
		}
		if (column != 0) {
			addLeft ();
		}
		if (column != 4) {
			addRight ();
		}

		addNothing ();
		}


}
