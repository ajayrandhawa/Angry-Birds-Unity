using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	Transform projecttile;
	public Transform farleft;
	public Transform farright;


	// Use this for initialization
	void Start () {

		projecttile = GameObject.Find("Player").GetComponent<Transform>();
		 
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 newPosition = transform.position;

		newPosition.x = projecttile.position.x;
		newPosition.x = Mathf.Clamp(newPosition.x,farleft.position.x,farright.position.x);

		transform.position = newPosition;
	
	}
}
