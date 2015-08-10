using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float Speed = 7;
	public float JumpSpeed = 20;
	public float Gravity = 9.8f;

	void Update ()
	{
		Movement();
	}

	void Movement ()
	{
		if (Input.GetKey (KeyCode.D))
		{
			transform.Translate(Vector2.right * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A))
		{
			transform.Translate(-Vector2.right * Speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Space))
		{
			transform.Translate(Vector2.up * Speed * Time.deltaTime);
		}
	}
}