using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTo : MonoBehaviour
{
    public GameObject[] goals;       //
    public GameObject currentGoal;   //
    public GameObject nextGoal;      //
    public int targetNumber;
    public Vector3 currentTarget;           //This will override the value of the unicorn's target in the "Character" script.
    //public bool hunting;

	private Character _character;
    
    // Start is called before the first frame update
    void Start()
    {
        targetNumber = 0;
        goals = GameObject.FindGameObjectsWithTag("UnicornGoal");

		_character = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
         GoToTarget();
         ChangeTarget();
    }

    void GoToTarget()   //Tells the unicorn to walk to this particular target
    {
       
        currentGoal = goals[targetNumber];
        currentTarget.x = currentGoal.transform.position.x;  
        currentTarget.y = currentGoal.transform.position.y;
        currentTarget.z = currentGoal.transform.position.z;
		_character.target = currentTarget;   //The unicorn's "Character"'s "target" Vector3 is being changed by THIS specific line of code.
    }

    void ChangeTarget() //Change which target the unicorn is currently walking towards.
    {                   //Goal: Once the unicorn has reached its target, take an object from the unicornGoals array and select one to become the new target
        if (transform.position == currentGoal.transform.position)
        {
            targetNumber = Random.Range(0, goals.Length);
        }
        /*
        if (targetNumber >= unicornGoals.Length)
        {
            targetNumber = 0;
        }
        */
        
        //Debug.Log(targetNumber);
    }



}
