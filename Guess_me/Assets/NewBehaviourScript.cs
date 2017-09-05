using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	int max = 100;
	int min = 1;
	int guess = 50;

	// Use this for initialization
	void Start () {


		print ("Welcome to Number Guess!");
		print ("Pick a number in your head.");

		print ("The largest number can be " +max);
		print ("The smallest number can be" +min);

		print ("Is the number higher or lower than" +guess);
		print ("Up arrow for higher, down arrow for lower, enter for equal.");
		max = max + 1

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Fun stuff");
			print ("Other stuff.");
			min = guess;
			guess = (max + min) / 2;
			print ("Is the number higher or lower than" +guess);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Fun stuff");
			print ("Cool");
		}
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Awesome");
			print ("Found it");
		}
	}
	
}
