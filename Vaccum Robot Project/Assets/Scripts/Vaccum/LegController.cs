using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegController : VaccumPartsController {


	public override void Start(){
		base.Start ();
	}

	/// <summary>
	/// Moves the vaccum to the specified direction.
	/// 0 : Right
	/// 1 : Down
	/// 2 : Left
	/// 3 : Up
	/// Changes the vaccum's position and adds score.
	/// </summary>
	/// <param name="direction">Direction</param>
	public void move(int direction){


		switch (direction) {
		case 0:
			vaccumC.position++;
			vaccumC.columnV++;
			break;
		case 1:
			vaccumC.position += 5;
			vaccumC.lineV++;
			break;
		case 2:
			vaccumC.position--;
			vaccumC.columnV--;
			break;
		case 3:
			vaccumC.position -= 5;
			vaccumC.lineV--;
			break;
		}


		vaccumC.nbMoves++; 
		vaccumC.transform.position = new Vector3 (vaccumC.startX + vaccumC.columnV * vaccumC.nextX, vaccumC.startY - vaccumC.lineV * vaccumC.nextY, 0);
		environementC.score += actionScore; 
		environementC.performanceScore += actionScore;
		environementC.electricityUsed++;

	}
}
