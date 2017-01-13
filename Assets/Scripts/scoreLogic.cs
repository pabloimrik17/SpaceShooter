using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreLogic : MonoBehaviour {

	Text text;

	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addToScore() {

	}
}
