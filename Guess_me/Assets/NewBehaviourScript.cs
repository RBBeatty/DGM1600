using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public Text textBox;

	int max = 100;
	int min = 1;
	int guess = 50;

	public int counter;

	// Use this for initialization
	void Start () {
		guess = Random.Range (min, max);

		textBox.text = "Wlcome to Number Guesser!"
					+ "\nPick a number in your head."
					+ "\nThe highest number you can pick is " + max	
					+ "\nThe lowes number you can pick is " + min
					+ "\n\nIs the number lower than " + guess
					+"\n Up arrow for higher, Down arrow for lower, Enter for equal";






		print ("Welcome to Number Guess!");
		print ("Pick a number in your head.");

		print ("The largest number can be " +max);
		print ("The smallest number can be" +min);

		print ("Is the number higher or lower than" +guess);
		print ("Up arrow for higher, down arrow for lower, enter for equal.");
		max = max + 1;

	}

	// Update is called once per frame
	void Update () {

		if (counter == -1) {

			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
				//counter--;
				print ("You Win!");
				textBox.text = "You win!";
			}
		}
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Fun stuff");
			textBox.text = "Fun stuff.";
			print ("Other stuff.");
			textBox.text = "Other stuff.";
			print ("Is the number higher or lower than" +guess);
			textBox.text = "Is the number higher or lower than " + guess;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Fun stuff");
			textBox.text = "Fun stuff.";
			print ("Cool");
			textBox.text = "Cool.";
		}
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Awesome");
			textBox.text = "Awesome.";
			print ("Found it");
			textBox.text = "Found it.";
		}
	}
	
}
