using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public GameObject scoreCounter;
    public GameObject aliveSprite;
    public GameObject deadSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            //Debug.Log("Unicorn ded :(");
            //this.GetComponent<Character>().speedAnim = 0;
            this.GetComponent<Character>().speedMove = 0;
            this.GetComponent<Animator>().SetBool("Dead", true);
            scoreCounter.GetComponent<Score>().enabled = false;
            aliveSprite.GetComponent<SpriteRenderer>().enabled = false;
            deadSprite.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
