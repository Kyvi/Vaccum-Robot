using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph {

	/// <summary>
	/// The root.
	/// </summary>
	public Node root;

	/// <summary>
	/// The depth of the graph.
	/// </summary>
	public int depth;

	/// <summary>
	/// The graph nodes.
	/// </summary>
	public List<Node> graphNodes;

	/// <summary>
	/// Initializes a new instance of the <see cref="Graph"/> class.
	/// </summary>
	/// <param name="n">root</param>
	/// <param name="d">depth</param>
	public Graph(Node n,int d){
		root = n;
		depth = d;
		graphNodes = new List<Node> ();
		createGraph ();
	}

	/// <summary>
	/// Creates the graphNodes.
	/// </summary>
	public void createGraph(){
		int d = depth; // Depth of the graph
		List<Node> aux = new List<Node> (); // Memory List
		List<Node> currentNodes = new List<Node> (); // Building List
		currentNodes.Add (root); // Adds root as the first node of the Building List.

		while (d >= 0) {
			for (int i = 0; i < currentNodes.Count; i++) {
				Node currentNode = currentNodes [i]; //takes out each Nodes from the Building list
				aux.Add (currentNodes [i]); // Adds the nodes to the memory List.
				graphNodes.Add (currentNodes [i]); // Adds the nodes to the graphNodes List.

			}
			currentNodes.Clear (); // Deletes the building list 
			for (int i = 0; i < aux.Count; i++) {
				aux [i].createChildren (); // Create children for every nodes of the memory List
				for (int j = 0; j < aux[i].children.Count; j++) {
					currentNodes.Add (aux [i].children [j]); // Adds those children to the building List
				}
			}
			aux.Clear (); // Deletes the memory List
			d--; 
		}

	}


}
