using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerLogic : MonoBehaviour {

	float maxPlayerDIstance = 29.0f;
	float projectileCollisionOffset = 3.0f;

	public float playerSpeed = 1.0f;
	public float shootSpeed = 0.5f;

	public bool isShooting = true;

	public GameObject projectile;

	// Use this for initialization
	void Start () {
		StartCoroutine(projectileShootTimer());
	}
	
	// Update is called once per frame
	void Update () {
		playerMovement();
	}

	void playerMovement() {
		if ((Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x >= -maxPlayerDIstance) {
			transform.Translate (-playerSpeed, 0, 0);
		} else if ((Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x <= maxPlayerDIstance) {
			transform.Translate (playerSpeed, 0, 0);
		}
	}

	IEnumerator projectileShootTimer() {
		while (isShooting) {
			spawnProjectile();
			yield return new WaitForSeconds(shootSpeed);
		}
	}

	void spawnProjectile() {
		Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + projectileCollisionOffset, 0) , Quaternion.identity);
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Collision") {
			SceneManager.LoadScene("GameScene");
		}
	}
}
