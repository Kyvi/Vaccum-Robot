using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : VaccumPartsController {


	public override void Start(){
		base.Start ();
	}

	/// <summary>
	/// Vaccums up the dust :
	/// Changes the room State and adds score.
	/// </summary>
	public void vaccumUp(){
		int roomState = environementC.rooms [vaccumC.position].state;
		if (roomState == 1) {
			roomState = 0;
			environementC.score += actionScore;
		}
		if (roomState == 3) {
			roomState = 2;
			environementC.score += actionScore;
		}
	}
}
