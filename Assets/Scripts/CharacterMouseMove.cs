using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouseMove : MonoBehaviour
{
	private Character _character;
	private Plane _plane = new Plane(Vector3.back, Vector3.zero);

	void Start()
    {
		_character = GetComponent<Character>();
    }
	
    void Update()
    {
        if (Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			float dist;
			_plane.Raycast(ray, out dist);

			var mouseWorld = ray.GetPoint(dist);
			
			_character.target = mouseWorld;
		}
    }
}
