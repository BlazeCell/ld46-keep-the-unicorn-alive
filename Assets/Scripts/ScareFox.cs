using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareFox : MonoBehaviour
{
    public GameObject self;
    public GameObject characterWithHealth;
    // Start is called before the first frame update
    void Start()
    {
        self = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (characterWithHealth.GetComponent<Health>().health <= 0)
        {
            self.GetComponent<SphereCollider>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Fox"))
        {
            //GameObject.FindWithTag("Fox").GetComponent<HuntMouse>().hunting = false;
            other.GetComponent<HuntMouse>().hunting = false;
        }
    }
    
}
