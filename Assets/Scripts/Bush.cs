using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
	public bool trap;
    //public bool inside;
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("It's working");
    }
    
    void OnTriggerEnter(Collider other)
    {
        //inside = true;
        if (trap == true)
        {
            Debug.Log("There was a trap!");
        }
        else
        {
            Debug.Log("There was no trap.");
        }
    }


}