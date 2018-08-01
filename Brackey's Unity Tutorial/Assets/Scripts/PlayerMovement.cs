using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	
	// Update is called once per frame 
	// FixedUpdate is better when messing with physics stuff
	void FixedUpdate () {
		
		// Add a forward force to our player
		rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

		// Move player to right when d is pressed
		if ( Input.GetKey("d") ) {
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// Move player to left when a is pressed
		if ( Input.GetKey("a") ) {
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// if you fall off the map, restart game
		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
