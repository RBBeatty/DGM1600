using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour {

	public Text textObject;

	public enum States {start, forest, forest_r, cave, shore, shore_0, shore_w, shore_r, shore_fixed}
	public States myState;

	public bool rope = false;
	public bool wood = false;



	// Use this for initialization
	void Start () {
		myState = States.start;
			

	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.start) {
			State_start ();
		} else if (myState == States.forest) {
			State_forest ();
		} else if (myState == States.cave) {
			State_cave ();
		} else if (myState == States.shore_0) {
			State_shore ();
		}
	}

	void State_start(){
		
		textObject.text = "Your are on a small desert Island." +
		"\n There is a forest with stringy trees." +
		"\n There is a cave as well." +
		"\n\nPress F to go to the Forest. Press C to go to te cave.";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.forest;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.cave;
		}
	}

	void State_forest(){
		if (rope == true){
			textObject.text = 

		}
	}

	void State_cave(){
		if (wood == true){
			textObject.text = ;
		}
	}
	void State_shore (){
		if (rope == true){
			textObject = "There is an old sailboat here." +
								"\nYou used the rope to fix the rigging." +
								"\n\nPress D to depart onboard the sailboat. Press C to go to cave. Press S to go to Start.";
						}
		if (wood == true){
			textObject.text = 
			}
	}
