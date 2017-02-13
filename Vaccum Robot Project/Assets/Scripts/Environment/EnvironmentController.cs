using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvironmentController : MonoBehaviour {

	/// <summary>
	/// UI text elements.
	/// </summary>
	public Text timeText; 
	public Text scoreText; 
	public Text performanceMesureText; 
	public Text scoreOverallText;
	public Text electricityUsedText;
	public Text dustText;
	public Text jewelText;
	public Text jewelLostText;

	/// <summary>
	/// The score overall that the vacuum tries to maximize.
	/// </summary>
	public int score = 0;

	/// <summary>
	/// The performance mesure : score per second.
	/// </summary>
	public int performanceScore;
	public float timeReset;
	public float performanceMesure = 0; 

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

	/// <summary>
	/// Some informations
	/// electricityUsed : amount of electricity used
	/// nbDust : number of dust vaccumed up
	/// nbJewel : number of jewel taken
	/// nbLostJewel : number of jewel vaccumed up
	/// </summary>
	public int electricityUsed = 0;
	public int nbDust = 0;
	public int nbJewel = 0;
	public int nbLostJewel = 0;

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
	}

	void Start () {
		waitDelay = new WaitForSeconds (timeDelay);
		StartCoroutine (generate ());
		InvokeRepeating ("printGlobalInfo", 0, 1);
	}

	void Update(){
		timeReset += Time.deltaTime;
		performanceMesure = (float)performanceScore / timeReset; // Score per second since the last reset
	}

	public void performanceReset(){
		timeReset = 0f;
		performanceScore = 0;
	}

	/// <summary>
	/// updates the UI text
	/// </summary>
	public void printGlobalInfo(){
		electricityUsedText.text = "Electricity used : " + electricityUsed;
		dustText.text = "Dust vaccumed : " + nbDust;
		jewelText.text = "Jewel saved : " + nbJewel;
		jewelLostText.text = "Jewel lost : " + nbLostJewel;

		timeText.text = "Time past : " + Time.time;
		performanceMesureText.text = "Score per second since perf. update : " + performanceMesure;
		scoreText.text = "Score overall : " + score;
		scoreOverallText.text = "Score per second overall : " + (float)score / Time.time;
	}

	/// <summary>
	/// Main method of the environment where it generates dust and jewels randomly
	/// </summary>
	private IEnumerator generate()
	{
		yield return waitDelay; 
		generateDust ();
		generateJewel ();
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
