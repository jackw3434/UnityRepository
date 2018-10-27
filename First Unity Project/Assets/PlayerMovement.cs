using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
       // Debug.Log("Hello World!");
        // rb.useGravity = false;
        //rb.AddForce(0,200,500);
	}
	
	// Update is called once per frame
	void Update () {		
       // rb.AddForce(0, 0, 2000 * Time.deltaTime);
	}

    void FixedUpdate()    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
