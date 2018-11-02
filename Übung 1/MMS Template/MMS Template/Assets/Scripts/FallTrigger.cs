using UnityEngine;

public class FallTrigger : MonoBehaviour
{

	private Capsule _myCP;

    void Start () {
        
    }
	
	
	void Update () {
       
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
	    _myCP = FindObjectOfType<Capsule>();
	   
	    _myCP.pushMe();
	    
	    Debug.Log("Hi there");
	    
	    Destroy(this);
        
    }
}
