using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	public Vector3 target;
	public float size = 1.0f;
	public float speed = 2.0f;

	private Animator _animator;
	private bool _walking = false;
	
    void Start()
    {
		_animator = GetComponent<Animator>();
    }
	
    void Update()
    {
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

		_walking = Vector2.Distance(transform.position, target) > 0.1f;
		_animator.SetBool("Walking", _walking);
    }
}
