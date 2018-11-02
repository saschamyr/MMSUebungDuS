using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {
	private float myThrust;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
		myThrust = 500.0f;
	}
	
	public void pushMe()
	{
		rb.AddForce(transform.forward * myThrust);
		
		
        
	}
	
	private void OnTriggerEnter(Collider other)
	{
		
	    
		Debug.Log("Hi there");
		Destroy(this);
        
		//DESTROY OBJECT HERE
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
