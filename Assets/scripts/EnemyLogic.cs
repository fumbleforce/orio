using UnityEngine;
using System.Collections;

public class EnemyLogic : MonoBehaviour {

	public Transform sightStart, sightEnd;

	public bool spotted = false;
	public bool facingLeft = true;

	public GameObject spottedCube;

	void Start()
	{
		InvokeRepeating("Patrol", 0f, Random.Range (2f,6f));
	}
	void Update ()
	{
		Raycasting();
		Behaviour();
	}

	void Raycasting()
	{
		//draws the line
		Debug.DrawLine (sightStart.position, sightEnd.position, Color.red);
		//detects the player
		spotted = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Player"));
	}

	void Behaviour()
	{
		if (spotted == true) {
			spottedCube.SetActive (true);
		}
		else
		{
			spottedCube.SetActive (false);
		}
	}

	void Patrol()
	{
		//Flip left and right at random intervals
		facingLeft = !facingLeft;

		if(facingLeft == true)
		{
			transform.eulerAngles = new Vector2 (0, 0);
		}
		else
		{
			transform.eulerAngles = new Vector2(0, 180);
		}

	}
}