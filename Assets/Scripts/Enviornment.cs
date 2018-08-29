using UnityEngine;
using System.Collections;

public class Enviornment : MonoBehaviour {

	public float fanSpeed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (0,0,fanSpeed);

	}
}
