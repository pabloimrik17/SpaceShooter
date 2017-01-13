using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTransform : MonoBehaviour {

	scoreLogic addToScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Collision") {
			Destroy (transformCollision.gameObject);

			addToScore = GetComponent<scoreLogic> ();
			addToScore.addToScore ();
		}
	}
}
