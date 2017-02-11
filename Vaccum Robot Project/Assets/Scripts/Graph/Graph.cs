using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph {

	public Node start;
	public int depth;

	public List<Node> graphNodes;

	public Graph(Node n,int d){
		start = n;
		depth = d;
		graphNodes = new List<Node> ();
		createGraph ();
	}

	public void createGraph(){
		int d = depth;
		List<Node> aux = new List<Node> ();
		List<Node> currentNodes = new List<Node> ();
		currentNodes.Add (start);

		while (d > 0) {
			for (int i = 0; i < currentNodes.Count; i++) {
				Node currentNode = currentNodes [i];
				aux.Add (currentNodes [i]);
				graphNodes.Add (currentNodes [i]);

			}
			currentNodes.Clear ();
			for (int i = 0; i < aux.Count; i++) {
				aux [i].createChildren ();
				for (int j = 0; j < aux[i].children.Count; j++) {
					currentNodes.Add (aux [i].children [j]);
				}
			}
			aux.Clear ();
			d--;
		}

	}


}
