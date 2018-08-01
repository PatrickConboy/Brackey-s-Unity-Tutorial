using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	// if you hit an object, stop movement and call EndGame function in GameManager
	void OnCollisionEnter (Collision collisionInfo) {
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
		}
	}

}
