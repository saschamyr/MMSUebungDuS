using UnityEngine;

public class FallTrigger : MonoBehaviour {

    private float thrust;
    private Rigidbody rb;
   

    void Start () {
        rb = GetComponent<Rigidbody>();
        thrust = 50.0f;
    }
	
	
	void Update () {
        rb.AddForce(transform.forward * thrust);
    }
}
