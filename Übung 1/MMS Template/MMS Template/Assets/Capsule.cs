using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour {

    private float myThrust;
    private Rigidbody rb;
   

    void Start () {
        rb = GetComponent<Rigidbody>();
        myThrust = 50.0f;
    }


    public void pushMe()
    {
        rb.AddForce(transform.forward * myThrust);
        
    }
    
    
    

    void Update () {
        
        
        
    }
 }
