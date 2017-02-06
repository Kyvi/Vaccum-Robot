using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : VaccumPartsController {

	public override void Start(){
		base.Start ();
	}

	/// <summary>
	/// Takes the Jewel :
	/// Changes the room State and adds score.
	/// </summary>
	public void take(){
		int roomState = environementC.rooms [vaccumC.position].state;
		if (roomState == 2) {
			roomState = 0;
			environementC.score +=  actionScore;
		}
		if (roomState == 3) {
			roomState = 1;
			environementC.score += actionScore;
		}
	}
}
