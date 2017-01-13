using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTransform : MonoBehaviour {

	scoreLogic addToScore;
	public GameObject particleExplosion;

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Collision") {

			spawnParticle(transformCollision.transform.position);
			Destroy (transformCollision.gameObject);
			callScoreLogic();
		}
	}

	void callScoreLogic() {
		addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<scoreLogic>();
		addToScore.addToScore ();
	}

	void spawnParticle(Vector2 tempPosition) {
		Instantiate(particleExplosion, tempPosition, Quaternion.identity);		
	}
}
