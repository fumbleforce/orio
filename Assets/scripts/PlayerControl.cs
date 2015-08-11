using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	//player
	public float Speed = 7;
	public float JumpSpeed = 20f;
	public bool grounded;
	public Transform JumpLineEnd;
	
	void Update ()
	{
		Movement();
		Raycasting ();
	}

	void Raycasting()
	{
		//draws the line
		Debug.DrawLine (this.transform.position, JumpLineEnd.position, Color.red);

		grounded = Physics2D.Linecast (this.transform.position, JumpLineEnd.position, 1 << LayerMask.NameToLayer ("Ground"));

		Physics2D.IgnoreLayerCollision (8, 10);
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
		if (Input.GetKeyDown (KeyCode.Space) && grounded == true)
		{
			transform.Translate (Vector2.up * JumpSpeed * Time.deltaTime);
		}
	}
}