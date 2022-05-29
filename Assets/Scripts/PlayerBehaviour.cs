using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour {
	public Joystick joystick;
	Rigidbody2D rb;
	float movement = 0f;
	public float movementSpeed = 10f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	public void Turbo(){
		rb.velocity = new Vector2(movement, 10);
	}
	
	// Update is called once per frame
	void Update () {
		movement = joystick.Horizontal * movementSpeed;
	}

	void FixedUpdate(){
		rb.velocity = new Vector2(movement, rb.velocity.y);
	}
}
