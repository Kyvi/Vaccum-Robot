using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node{


	public int id;
	public int type;

	public int line;
	public int column;

	public int depth;

	public Node father;
	public List<Node> children;

	public int nbRooms;
	public int[] states;


	public Node(int type, int id, int line, int column, int nb, int[] states, int depth, Node father){
		this.type = type;
		this.id = id;
		this.line = line;
		this.column = column;
		nbRooms = nb;
		this.states = new int[nbRooms];
		for (int i = 0; i < nbRooms; i++) {
			this.states [i] = states [i];
		}

		this.depth = depth;
		this.father = father;

		children = new List<Node> ();

	}

	public void addVaccumUp(int[] s){
		children.Add (new Node (4, id, line, column, nbRooms, s, depth+1,this));
	}

	public void addTake(int[] s){
		children.Add (new Node (5, id, line, column, nbRooms, s, depth+1,this));
	}

	public void addRight(int[] s){
		children.Add (new Node (0, id+1, line, column+1, nbRooms, s, depth+1,this));
	}

	public void addLeft(int[] s){
		children.Add (new Node (2, id-1, line, column+1, nbRooms, s, depth+1,this));
	}

	public void addTop(int[] s){
		children.Add (new Node (3, id-5, line-1, column, nbRooms, s, depth+1,this));
	}

	public void addBottom(int[] s){
		children.Add (new Node (1, id+5, line+1, column, nbRooms, s, depth+1,this));
	}

	public void addNothing(int[] s){
		children.Add(new Node(-1,id,line,column, nbRooms, s, depth+1,this));
	}

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
		
		addNothing (states);
		addVaccumUp (states);
		addTake (states);

		if (line != 0) {
			addTop (states);
		}
		if (line != 4) {
			addBottom (states);
		}
		if (column != 0) {
			addLeft (states);
		}
		if (column != 4) {
			addRight (states);
		}

		}


}
