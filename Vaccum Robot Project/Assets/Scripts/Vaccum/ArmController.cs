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
		environementC.electricityUsed++;
		vaccumC.nbTake++; 
		int roomState = environementC.rooms [vaccumC.position].state;
		switch (roomState) {
		case 0:
			environementC.score -= 1;
			environementC.performanceScore -= 1;
			break;
		case 1:
			environementC.score -=  1;
			environementC.performanceScore -= 1;
			break;
		case 2:
			environementC.nbJewel++;
			environementC.rooms [vaccumC.position].state = 0;
			environementC.score +=  actionScore;
			environementC.performanceScore += actionScore;
			Destroy (environementC.roomJewel [vaccumC.position]);
			break;
		case 3:
			environementC.nbJewel++;
			environementC.rooms [vaccumC.position].state = 1;
			environementC.score += actionScore;
			environementC.performanceScore += actionScore;
			Destroy (environementC.roomJewel [vaccumC.position]);
			break;
		}
	}
}
