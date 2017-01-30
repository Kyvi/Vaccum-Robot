using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room {

	/// <summary>
	/// The ID of the room
	/// </summary>
	public int ID;

	/// <summary>
	/// The state of the room :
	/// 0 : empty
	/// 1 : dust
	/// 2 : jewel
	/// 3 : dust and jewel
	/// </summary>
	public int state;

	/// <summary>
	/// line and column of the room : graphic position
	/// </summary>
	public int line;
	public int column;

	/// <summary>
	/// dustProbability : Probability of dust appearing
	/// jewelProbability : Probability of jewel appearing
	/// </summary>
	public float dustProbability;
	public float jewelProbability;

	/// <summary>
	/// Initializes a new instance of the Room class.
	/// </summary>
	/// <param name="i">The ID</param>
	/// <param name="s">the state</param>
	/// <param name="l">the line</param>
	/// <param name="c">the column</param>
	/// <param name="dP">the dust probability</param>
	/// <param name="jP">the jewel probability</param>
	public Room(int i, int s, int l, int c, float dP, float jP){
		ID = i;
		state = s;
		line = l;
		column = c;
		dustProbability = dP;
		jewelProbability = jP;
	}

	/// <summary>
	/// Calculates the distance to another room r
	/// </summary>
	/// <param name="r">the other room r</param>
	public int distance(Room r){
		return Mathf.Abs (line - r.line) + Mathf.Abs (column - r.column);
	}

	///public void move(Room r){
	///	if(positionX < r.column){
	/// positionX++;
	/// } else{
		/// if(positionX > r.column){
		/// positionX--;
		/// }
		/// else{
			/// if(positionY < r.line){
			/// positionY++;
			/// }
			///else{
				/// if(positionX > r.line){
				/// positionY--;
				/// }
	/// 		
	///}
}
