using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour
{
	public bool inside;
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider2D other)
    {
        inside = true;
        Debug.Log("Currently in mud");
        
    }
    void OnTriggerExit(Collider2D other)
    {
        inside = false;
        Debug.Log("Currently out of mud");

    }

}