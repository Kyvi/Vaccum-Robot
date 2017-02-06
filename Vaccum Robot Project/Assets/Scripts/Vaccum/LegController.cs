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
	/// 3 : Bottom
	/// Changes the vaccum's position and adds score.
	/// </summary>
	/// <param name="direction">Direction</param>
	public void move(int direction){
		switch (direction) {
		case 0:
			vaccumC.position++;
			vaccumC.lineV++;
			break;
		case 1:
			vaccumC.position += 5;
			vaccumC.columnV++;
			break;
		case 2:
			vaccumC.position--;
			vaccumC.lineV--;
			break;
		case 3:
			vaccumC.position -= 5;
			vaccumC.columnV--;
			break;
		}
		environementC.score += actionScore;
	}
}
