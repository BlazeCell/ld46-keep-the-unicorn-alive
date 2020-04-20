using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntMouse : MonoBehaviour
{
    public GameObject player;
    public GameObject foxHole;
    public bool hunting;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (hunting == true)
        {
            GetComponent<BoxCollider>().enabled = true;
            GetComponent<Character>().speedMove = 1;
            GetComponent<Character>().speedAnim = 1;
            GetComponent<Character>().target.x = player.transform.position.x;
            GetComponent<Character>().target.y = player.transform.position.y;
            GetComponent<Character>().target.z = player.transform.position.z;
        }

        else
        {
            hunting = false;
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Character>().speedMove = 4;
            GetComponent<Character>().speedAnim = 4;
            GetComponent<Character>().target.x = foxHole.transform.position.x;
            GetComponent<Character>().target.y = foxHole.transform.position.y;
            GetComponent<Character>().target.z = foxHole.transform.position.z;

            if (transform.position == foxHole.transform.position)
            {
                hunting = true;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            other.GetComponent<Health>().health = 0;
        }
    }
}
