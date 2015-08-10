using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	float Speed = 5;

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