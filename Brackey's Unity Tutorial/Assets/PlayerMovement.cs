using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;
	
	// Update is called once per frame 
	// FixedUpdate is better when messing with physics stuff
	void FixedUpdate () {
		// * Time.deltaTime evens out force refresh for all frame rates
		rb.AddForce(0, 0, 2000 * Time.deltaTime); 
	}
}
