using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccumPartsController : MonoBehaviour {

	/// <summary>
	/// Score for doing the part action
	/// </summary>
	public int actionScore;

	/// <summary>
	/// setActionTime : The time needed for the part to do its action.
	/// </summary>
	public float ActionTime;


	/// <summary>
	/// Reference to the actual VaccumController and EnvironmentController
	/// </summary>
	protected VaccumController vaccumC;
	protected EnvironmentController environementC;

	public virtual void Start (){
		vaccumC = gameObject.GetComponent<VaccumController>();
		environementC = vaccumC.environment.GetComponent<EnvironmentController>();
	}
}
