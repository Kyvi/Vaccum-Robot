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
		vaccumC.nbVaccum++;
		int roomState = environementC.rooms [vaccumC.position].state;
		switch (roomState) {
		case 0:
			environementC.score -= 1;
			environementC.performanceScore -= 1;
			break;
		case 1:
			environementC.nbDust++;
			environementC.rooms [vaccumC.position].state = 0;
			environementC.score += actionScore;
			environementC.performanceScore += actionScore;
			Destroy (environementC.roomDust [vaccumC.position]);
			break;
		case 2:
			environementC.nbLostJewel++;
			environementC.score += stealingJewelScore;
			environementC.performanceScore += stealingJewelScore;
			Destroy (environementC.roomJewel [vaccumC.position]);
			break;
		case 3:
			environementC.nbDust++;
			environementC.nbLostJewel++;
			environementC.rooms [vaccumC.position].state = 0;
			environementC.score = environementC.score + actionScore + stealingJewelScore;
			environementC.performanceScore = environementC.performanceScore + actionScore + stealingJewelScore;
			Destroy (environementC.roomDust [vaccumC.position]);
			Destroy (environementC.roomJewel [vaccumC.position]);
			break;
		}
	}
}
