using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	
	// Update is called once per frame 
	// FixedUpdate is better when messing with physics stuff
	void FixedUpdate () {
		
		// Add a forward force to our player
		rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
	}
}
