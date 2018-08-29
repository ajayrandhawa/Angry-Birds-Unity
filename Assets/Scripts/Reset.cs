using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	public Rigidbody2D projecttile;
	public float resetSpeed = 0.025f;

	private float resetSpeedSqr;
	private SpringJoint2D spring;

	// Use this for initialization
	void Start () {

		resetSpeedSqr = resetSpeed * resetSpeed;
		spring = projecttile.GetComponent<SpringJoint2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.R)){
			reset();
		}

		if(spring == null && projecttile.velocity.sqrMagnitude < resetSpeedSqr){
			reset();
		}
	
	}

	void OnTriggerExit2D(Collider2D other){

		if(other.gameObject == projecttile){
			reset();
		}
	}

	void reset(){

		Application.LoadLevel(Application.loadedLevel);

	}
}
