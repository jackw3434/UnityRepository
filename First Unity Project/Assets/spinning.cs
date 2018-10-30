using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinning : MonoBehaviour {
	public Transform Transform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Transform.Rotate(Vector3.right*200 * Time.deltaTime);
	}
}
