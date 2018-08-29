using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BirdsReload : MonoBehaviour {


	public GameObject Bird;

	public int Birdcount =  0;

	Transform projecttile;
	public Transform farleft;
	public Transform farright;
	

	// Use this for initialization
	void Start () {

		while(Birdcount < 1){
		GameObject birdaction = (GameObject)Instantiate(Bird);
			Birdcount++;
		}

		}
	
	// Update is called once per frame
	void Update () {

		projecttile = GameObject.Find("Player").GetComponent<Transform>();
		Vector3 newPosition = transform.position;
		
		newPosition.x = projecttile.position.x;
		newPosition.x = Mathf.Clamp(newPosition.x,farleft.position.x,farright.position.x);
		
		transform.position = newPosition;


	}
	
}
