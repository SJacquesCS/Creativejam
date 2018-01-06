﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballController : MonoBehaviour
{
	void Awake()
	{
		Cursor.visible = false;
		Physics2D.IgnoreCollision(GameObject.FindGameObjectWithTag("mage").GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}

	void Update ()
	{
		Move ();
	}

	void Move()
	{
		float X = Input.mousePosition.x;
		float Y = Input.mousePosition.y;
			
		Vector3 mouselocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		GetComponent<Rigidbody2D>().MovePosition(new Vector2(mouselocation.x, mouselocation.y));
	}

}