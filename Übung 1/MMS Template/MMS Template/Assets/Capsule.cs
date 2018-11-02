using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour {

    private float myThrust;
    private Rigidbody rb;
    private BallScript _myBL;

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
        _myBL = FindObjectOfType<BallScript>();
	   
        _myBL.pushMe();
	    
        Debug.Log("Hi there");
        
        //DESTROY OBJECT HERE
        
    }
    
    

    void Update () {
        
        
        
    }
 }
