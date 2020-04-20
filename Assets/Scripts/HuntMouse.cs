using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntMouse : MonoBehaviour
{
    public GameObject player;
    public GameObject foxHole;
    public bool hunting;
    public bool caught;
    private float speedMove;
    
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Character>().speedMove = speedMove;
    }


    // Update is called once per frame
    void Update()
    {
        if (hunting == true)
        {
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<Character>().speedMove = 2;
            GetComponent<Character>().speedAnim = 2;
            GetComponent<Character>().target.x = player.transform.position.x;
            GetComponent<Character>().target.y = player.transform.position.y;
            GetComponent<Character>().target.z = player.transform.position.z;
        }

        else
        {
            hunting = false;
            caught = false;
            GetComponent<BoxCollider>().enabled = false;
            speedMove = 4;
            GetComponent<Character>().speedAnim = 4;
            GetComponent<Character>().target.x = foxHole.transform.position.x;
            GetComponent<Character>().target.y = foxHole.transform.position.y;
            GetComponent<Character>().target.z = foxHole.transform.position.z;

            if (transform.position == foxHole.transform.position)
            {
                hunting = true;
            }
        }

        if (caught == true)
        {
            player.GetComponent<Caught>().caught = true;
        }
        else
        {
            player.GetComponent<Caught>().caught = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            caught = true;
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            caught = false;
        }
    }
    */
}
