using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		
		Camera mcam = GameObject.Find("Main Camera").GetComponent<Camera>();
		mcam.orthographicSize = 8;
	}
}
