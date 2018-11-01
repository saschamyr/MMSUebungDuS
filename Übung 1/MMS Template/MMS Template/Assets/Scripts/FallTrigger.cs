using UnityEngine;

public class FallTrigger : MonoBehaviour
{

	public Capsule myCP;

    void Start () {
        
    }
	
	
	void Update () {
       
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
      // myCP.pushMe();
	    
	    Debug.Log("Hi there");
        
    }
}
