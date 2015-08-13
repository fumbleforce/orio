using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = player.position;
		pos.z = transform.position.z;
		transform.position = pos;	
	}
}
