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
    public GameObject trapSprite;
    public GameObject trapSprungSprite;

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
                trapSprungSprite.GetComponent<SpriteRenderer>().enabled = true;
                trapSprite.GetComponent<SpriteRenderer>().enabled = false;
                trap = false;
                //Debug.Log("There was a trap!");
            }
		}

        if (other.tag.Equals("Player"))
        {
            if (trap)
            {
                trap = false;
                trapDisarmed.Play();
                trapSprite.GetComponent<SpriteRenderer>().enabled = false;
                trapSprungSprite.GetComponent<SpriteRenderer>().enabled = false;
                //Debug.Log("Trap disarmed. That was close!");
            }

        }

        if (other.tag.Equals("Hunter"))
        {
            trap = true;
            trapSet.pitch = Random.Range(0.8f, 1.2f);
            trapSet.Play();
            trapSprungSprite.GetComponent<SpriteRenderer>().enabled = false;
            trapSprite.GetComponent<SpriteRenderer>().enabled = true;
            //Debug.Log("The fox has armed a trap!");
        }
    }


}