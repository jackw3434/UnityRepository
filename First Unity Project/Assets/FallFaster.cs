using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFaster : MonoBehaviour {

    public Rigidbody rb;
    public Transform Transform;
    public int i;
    public int f = 200;
    // Use this for initialization
    void Start() {
        for (i = 1; i < f; i++ ) {
            rb.AddForce(0, 1, 0);
            Debug.Log("The number is " + i);
            Debug.Log("The position is " + transform.position);
        }
        if (i == 200)
        {
            rb.AddForce(0, -200, 0);
            transform.position = new Vector3(0, 0, 0);
            transform.localScale = new Vector3(10, 10, 10);         
        }
       // rb.AddForce(0,-1000,0);
	}
	
	// Update is called once per frame
	void Update () {
    
       
    }
}
