using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	/// <summary>
	/// setActionTime : The time needed for the camera to do its action.
	/// </summary>
	public float ActionTime;

	/// <summary>
	/// Reference to the actual EnvironmentController.
	/// </summary>
	private EnvironmentController environmentC;

	void Start(){
		environmentC = gameObject.GetComponentInParent<EnvironmentController>();
	}

	/// <summary>
	/// Checks the specified id_room state.
	/// </summary>
	/// <param name="id_room">Room ID</param>
	public int view(int id_room ){
		return environmentC.rooms[id_room].state;
	}

}
