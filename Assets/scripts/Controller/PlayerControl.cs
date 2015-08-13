using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	//player
	public float Speed = 2;
	public float JumpSpeed = 1;
	
	void Update ()
	{
		Movement ();
	}

	void Movement()
	{
		if (Input.GetKey (KeyCode.D))
		{
			//moves the player to the right
			transform.Translate (Vector2.right * Speed * Time.deltaTime);
			//Flips the sprite, so that it looks to the right
			transform.eulerAngles = new Vector2(0, 0);
		}
		if (Input.GetKey (KeyCode.A))
		{
			// moves the player to the left, because the vector also gets flipped
			transform.Translate (Vector2.right * Speed * Time.deltaTime);
			//flips the vector and sprite
			transform.eulerAngles = new Vector2(0, 180);
		}
		if (Input.GetKey (KeyCode.Space))
		{
			transform.Translate (Vector2.up * JumpSpeed * Time.deltaTime);
		}
	}
}