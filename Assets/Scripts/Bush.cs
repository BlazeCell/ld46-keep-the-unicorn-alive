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
    public AudioSource trapSprung;
    public AudioSource trapDisarmed;
    public AudioSource trapSet;

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
		if (other.tag.Equals("Unicorn"))
		{
			var unicornHealth = other.GetComponent<Health>();

			//inside = true;
			if (trap)
			{
				unicornHealth.health = unicornHealth.health - 3;
                trapSprung.Play();
                other.GetComponent<Character>()._inPain = true;
                
                //Debug.Log("There was a trap!");
            }
			else
			{
				//Debug.Log("There was no trap.");
			}
		}

        if (other.tag.Equals("Player"))
        {
            if (trap)
            {
                trap = false;
                trapDisarmed.Play();
                //Debug.Log("Trap disarmed. That was close!");
            }

        }

        if (other.tag.Equals("Fox"))
        {
            trap = true;
            trapSet.Play();
            //Debug.Log("The fox has armed a trap!");
        }
    }


}