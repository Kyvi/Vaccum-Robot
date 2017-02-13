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
		environementC.electricityUsed++;
		int roomState = environementC.rooms [vaccumC.position].state;
		if (roomState == 1) {
			environementC.nbDust++;
			environementC.rooms [vaccumC.position].state = 0;
			environementC.score += actionScore;
			environementC.performanceScore += actionScore;
			Destroy (environementC.roomDust [vaccumC.position]);
		}
		if (roomState == 2) {
			environementC.nbLostJewel++;
			environementC.score += stealingJewelScore;
			environementC.performanceScore += stealingJewelScore;
			Destroy (environementC.roomJewel [vaccumC.position]);
		}
		if (roomState == 3) {
			environementC.nbDust++;
			environementC.nbLostJewel++;
			environementC.rooms [vaccumC.position].state = 0;
			environementC.score = environementC.score + actionScore + stealingJewelScore;
			environementC.performanceScore = environementC.performanceScore + actionScore + stealingJewelScore;
			Destroy (environementC.roomDust [vaccumC.position]);
			Destroy (environementC.roomJewel [vaccumC.position]);
		}
	}
}
