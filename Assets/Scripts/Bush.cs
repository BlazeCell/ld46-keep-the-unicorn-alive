using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
	public bool trap;
    //public bool inside;
    public GameObject unicorn;
    public float isItTrapped;
    public float chanceOfTrap;

    // Start is called before the first frame update
    void Start()
    {
        isItTrapped = Random.Range(0, 100);
        if (isItTrapped > chanceOfTrap)
        {
            trap = true;
        }
        //unicorn = GameObject.Find("Unicorn");
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
            unicorn.GetComponent<Health>().health = unicorn.GetComponent<Health>().health - 3;
            Debug.Log("There was a trap!");
        }
        else
        {
            Debug.Log("There was no trap.");
        }
    }


}