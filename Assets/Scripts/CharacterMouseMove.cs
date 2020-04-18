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
			var mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mouseWorld.z = 0.0f;
			_character.target = mouseWorld;
		}
    }
}
