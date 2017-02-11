using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour {

	/// <summary>
	/// The score that the vacuum tries to maximise.
	/// </summary>
	public int score = 0;

	/// <summary>
	/// The number of rooms.
	/// </summary>
	public int nbRooms = 25;

	/// <summary>
	/// The number of rooms per line/column
	/// </summary>
	private int nbRoomsLine = 5;

	/// <summary>
	/// The rooms.
	/// </summary>
	public Room[] rooms;

	/// <summary>
	/// distance[i][j] gives the distance between room i and j
	/// </summary>
	public int[][] distanceTable;

	/// <summary>
	/// The dust and jewel prefab
	/// </summary>
	public GameObject dust;
	public GameObject jewel;

	public GameObject[] roomDust;
	public GameObject[] roomJewel;

	/// <summary>
	/// Some Graphics utilities :
	/// startXDust : horizontal position of room 0 's Dust
	/// startYDust : vertical position of room 0 's Dust
	/// startXJewel : horizontal position of room 0 's Jewel
	/// startYJewel : vertical position of room 0 's Jewel
	/// nextX : horizontal distance between each room
	/// nextY : vertical distance between each room
	/// </summary>
	public float startXDust = 0.6f;
	public float startYDust = 1.8f;
	public float startXJewel = 1f;
	public float startYJewel = 2f;
	public float nextX = 2.33f;
	public float nextY = 1.47f;

	/// <summary>
	/// timeDelay : delay between each random changes
	/// waitDelay : delay between each random changes
	/// </summary>
	public float timeDelay = 0.1f;
	private WaitForSeconds waitDelay;

	void Awake(){
		roomDust = new GameObject[nbRooms];
		roomJewel = new GameObject[nbRooms];

		// instantiates the 25 rooms of the environment 
		rooms = new Room[nbRooms];
		for (int i = 0; i < nbRooms; i++) {
			float dustP = Random.value / 50;
			float jewelP = Random.value / 200;
			rooms [i] = new Room (i, 0, i / nbRoomsLine, i % nbRoomsLine, dustP, jewelP);
		}

		// instantiates the distanceTable 
		distanceTable = new int[nbRooms] [];
		for (int i=0; i< nbRooms;i++){
			distanceTable [i] = new int[nbRooms];
		}

		// sets one half of distanceTable by calculating the distance between each rooms
		for (int i = 0; i < nbRooms; i++) {
			for (int j = i; j < nbRooms; j++) {
				distanceTable [i] [j] = rooms [i].distance (rooms [j]);
			}
		}

		// as the distance between room i and j is the same as between room j and i,
		// sets other half of distanceTable without calculating the distance between each rooms
		for (int i = 1; i < nbRooms; i++) {
			for (int j = 0; j < i; j++) {
				distanceTable [i] [j] = distanceTable [j] [i];
			}
		}
	}

	void Start () {
		waitDelay = new WaitForSeconds (timeDelay);
		StartCoroutine (generate ());
	}

	/// <summary>
	/// Main method of the environment where it generates dust and jewels randomly
	/// </summary>
	private IEnumerator generate()
	{
		yield return waitDelay;
		generateDust ();
		generateJewel ();
		// Debug.Log ((float)score/Time.time);
		StartCoroutine(generate ());

	}
		

	/// <summary>
	/// Navigates through the rooms and generate dust in them or not according to a random factor.
	/// </summary>
	public void generateDust(){
		
		// Room navigation loop
		for (int i = 0; i < nbRoomsLine; i++) {
			for (int j = 0; j < nbRoomsLine; j++) {
				int roomNumber = j * nbRoomsLine + i; // calculates room ID
				Room room = rooms [roomNumber]; // gets the room associated with the room ID
				int roomState = room.state; // gets the room current state


				if (roomState!= 1 && roomState!= 3) { // in case there wasn't already dust in the room
					float value = Random.value; // determines a random float bewtween 0 inclusive and 1 inclusive
					if (value <= room.dustProbability) { // in case random decided there would be dust in this room
						Vector3 pos = new Vector3 (); // the position of the dust
						pos.x = startXDust + i * nextX; // sets the horizontal position of the dust
						pos.y = startYDust - j * nextY; // sets the vertical position of the dust
						GameObject g = Instantiate (dust, pos, Quaternion.identity); // instantiate the dust at the given position
						roomDust[roomNumber] = g;
						if (roomState == 0) { // change room state to 1 if there was nothing or 3 if there was a jewel
							room.state = 1;
						} else {
							room.state = 3;
						}
					}
				}

			}
		}
	}

	/// <summary>
	/// Navigates through the rooms and generate jewel in them or not according to a random factor.
	/// </summary>
	public void generateJewel(){
		
		// Room navigation loop
		for (int i = 0; i < nbRoomsLine; i++) {
			for (int j = 0; j < nbRoomsLine; j++) {
				int roomNumber = j * nbRoomsLine + i; // calculates room ID
				Room room = rooms [roomNumber]; // gets the room associated with the room ID
				int roomState = room.state; // gets the room current state

				if (roomState!= 2 && roomState!= 3) { // in case there wasn't already a jewel in the room
					float value = Random.value; // determines a random float bewtween 0 inclusive and 1 inclusive
					if (value <= room.jewelProbability) { // in case random decided there would be a jewel in this room
						Vector3 pos = new Vector3 (); // the position of the jewel
						pos.x = startXJewel + i * nextX; // sets the horizontal position of the jewel
						pos.y = startYJewel - j * nextY; // sets the vertical position of the jewel
						GameObject g = Instantiate (jewel, pos, Quaternion.identity); // instantiate the jewel at the given position
						roomJewel[roomNumber] = g;
						if (roomState == 0) { // change room state to 2 if there was nothing or 3 if there was dust
							room.state = 2;
						} else {
							room.state = 3;
						}
					}
				}

			}
		}
	}
}
