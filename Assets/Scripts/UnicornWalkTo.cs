using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornWalkTo : MonoBehaviour
{
    public GameObject[] unicornGoals;       //
    public GameObject unicornCurrentGoal;   //
    public GameObject unicornNextGoal;      //
    public int targetNumber;
    public Vector3 currentTarget;           //This will override the value of the unicorn's target in the "Character" script.

	private Character _character;
    
    // Start is called before the first frame update
    void Start()
    {
        targetNumber = 0;
        unicornGoals = GameObject.FindGameObjectsWithTag("UnicornGoal");

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
       
        unicornCurrentGoal = unicornGoals[targetNumber];
        currentTarget.x = unicornCurrentGoal.transform.position.x;  
        currentTarget.y = unicornCurrentGoal.transform.position.y;
        currentTarget.z = unicornCurrentGoal.transform.position.z;
		_character.target = currentTarget;   //The unicorn's "Character"'s "target" Vector3 is being changed by THIS specific line of code.
    }

    void ChangeTarget() //Change which target the unicorn is currently walking towards.
    {                   //Goal: Once the unicorn has reached its target, take an object from the unicornGoals array and select one to become the new target
        if (transform.position == unicornCurrentGoal.transform.position)
        {
            targetNumber = targetNumber + 1;
        }
        
        if (targetNumber >= unicornGoals.Length)
        {
            targetNumber = 0;
        }

        //Debug.Log(targetNumber);
    }
}
