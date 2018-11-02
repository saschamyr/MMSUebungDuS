using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	private float myThrust;
	private Rigidbody rb;
	private CubeScript _myCB;
   

	void Start () {
		rb = GetComponent<Rigidbody>();
		myThrust = 500.0f;
	}


	public void pushMe()
	{
		rb.AddForce(transform.forward * myThrust);
        
	}
	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		_myCB = FindObjectOfType<CubeScript>();
	   
		_myCB.pushMe();
	    
		Debug.Log("Hi there");
		
		
		//DESTROY OBJECT HERE
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	
}
