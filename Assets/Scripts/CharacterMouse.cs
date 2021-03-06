﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMouse : MonoBehaviour
{
	public Vector3 target;
	public float size = 1.0f;
	public float speedMove = 1.0f;
	public float speedAnim = 1.0f;
	private float caughtSpeed;
	private float notCaughtSpeed;
	

	private Animator _animator;
	private SpriteRenderer _spriteRenderer;
	private bool _walking = false;
	public bool _inPain = false;
	public bool caught;

	void Start()
	{
		_animator = GetComponent<Animator>();
		_spriteRenderer = GetComponentInChildren<SpriteRenderer>();
		caughtSpeed = speedMove / 2;
		notCaughtSpeed = speedMove;
	}

	void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, target, speedMove * Time.deltaTime);

		_walking = Vector2.Distance(transform.position, target) > 0.1f;
		_animator.SetBool("Walking", _walking);

		_animator.speed = speedAnim;

		// This verbose if allows us to not change the flip if the x values are equal.
		if (target.x > transform.position.x)
			_spriteRenderer.flipX = true;
		else
		if (target.x < transform.position.x)
			_spriteRenderer.flipX = false;

		if (_inPain == true)    //Play pain animation
		{
			GetComponent<Animator>().SetBool("InPain", true);
			_inPain = false;
		}
		else
		{
			GetComponent<Animator>().SetBool("InPain", false);
		}

		if (caught == true)
		{
			speedMove = caughtSpeed;
		}
		else
		{
			speedMove = notCaughtSpeed;
		}

	}
}

