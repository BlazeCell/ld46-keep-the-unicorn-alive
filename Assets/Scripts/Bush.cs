using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
	public bool trap;
	

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