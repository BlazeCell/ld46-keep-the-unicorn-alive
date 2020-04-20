using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caught : MonoBehaviour
{
    public GameObject player;
    public bool caught;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (caught == true)
        {
            player.GetComponent<Character>().caught = true;
        }
        else
        {
            player.GetComponent<Character>().caught = false;
        }
    }
}
