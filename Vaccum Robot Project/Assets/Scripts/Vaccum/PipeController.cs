using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : VaccumPartsController {

	public int stealingJewelScore = -20;

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
			environementC.rooms [vaccumC.position].state = 0;
			environementC.score += actionScore;
			Destroy (environementC.roomDust [vaccumC.position]);
		}
		if (roomState == 2) {
			environementC.score -= stealingJewelScore;
			Destroy (environementC.roomJewel [vaccumC.position]);
		}
		if (roomState == 3) {
			environementC.rooms [vaccumC.position].state = 0;
			environementC.score += actionScore;
			environementC.score -= stealingJewelScore;
			Destroy (environementC.roomDust [vaccumC.position]);
			Destroy (environementC.roomJewel [vaccumC.position]);
		}
	}
}
