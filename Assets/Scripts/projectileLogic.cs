using UnityEngine;
using System.Collections;

public class projectileLogic : MonoBehaviour {

	public float transformSpeed = 0.4f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveTransformToTop();
	}

	void moveTransformToTop() {
		transform.Translate(0, transformSpeed, 0);
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}
