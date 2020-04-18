using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouseMove : MonoBehaviour
{
	private Character _character;

    void Start()
    {
		_character = GetComponent<Character>();
    }
	
    void Update()
    {
        if (Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Plane plane = new Plane(Vector3.back, Vector3.zero);
			float dist;
			plane.Raycast(ray, out dist);

			//var mousePos = Input.mousePosition;
			//mousePos.z = 0.0f;
			//var mouseWorld = Camera.main.ScreenToWorldPoint(mousePos);
			var mouseWorld = ray.GetPoint(dist);
			
			Debug.Log(mouseWorld);
			_character.target = mouseWorld;
		}
    }
}
