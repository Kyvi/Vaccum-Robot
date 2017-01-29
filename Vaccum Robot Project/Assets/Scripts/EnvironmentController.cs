using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour {
	
	public int score = 0;
	public int nbRooms = 25;
	private int nbRoomsLine = 5;

	public int[] rooms;
	public float[] dustProbability;
	public float[] jewelProbability;

	public GameObject dust;
	public GameObject jewel;

	public float startXDust = 0.6f;
	public float startYDust = 1.8f;
	public float startXJewel = 1f;
	public float startYJewel = 2f;
	public float nextX = 2.33f;
	public float nextY = 1.47f;

	public float timeDelay = 0.1f;
	private float previousTime = 0f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			if (Time.time > previousTime + timeDelay) {
			previousTime = Time.time;
			generateDust ();
			generateJewel ();
		}
		
	}

	public void generateDust(){
		Vector3 pos = new Vector3 ();
		for (int i = 0; i < nbRoomsLine; i++) {
			for (int j = 0; j < nbRoomsLine; j++) {
				int roomNumber = j * nbRoomsLine + i;

				if (rooms [roomNumber] != 1 && rooms [roomNumber] != 3) {
					pos.x = startXDust + i * nextX;
					pos.y = startYDust - j * nextY;
					float value = Random.value;
					if (value <= dustProbability [roomNumber]) {
						Instantiate (dust, pos, Quaternion.identity);
						if (rooms [roomNumber] == 0) {
							rooms [roomNumber] = 1;
						} else {
							rooms [roomNumber] = 3;
						}
					}
				}

			}
		}
	}

	public void generateJewel(){
		Vector3 pos = new Vector3 ();
		for (int i = 0; i < nbRoomsLine; i++) {
			for (int j = 0; j < nbRoomsLine; j++) {
				int roomNumber = j * nbRoomsLine + i;

				if (rooms [roomNumber] != 2 && rooms [roomNumber] != 3) {
					pos.x = startXJewel + i * nextX;
					pos.y = startYJewel - j * nextY;
					float value = Random.value;
					if (value <= dustProbability [roomNumber]) {
						Instantiate (jewel, pos, Quaternion.identity);
						if (rooms [roomNumber] == 0) {
							rooms [roomNumber] = 2;
						} else {
							rooms [roomNumber] = 3;
						}
					}
				}

			}
		}
	}
}
