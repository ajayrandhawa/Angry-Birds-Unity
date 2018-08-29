using UnityEngine;
using System.Collections;

public class first : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(loadSc());
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	IEnumerator loadSc(){
		
		yield return new WaitForSeconds(4);

		Application.LoadLevel("2");

}

}
