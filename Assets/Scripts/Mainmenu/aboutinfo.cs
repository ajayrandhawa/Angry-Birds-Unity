using UnityEngine;
using System.Collections;

public class aboutinfo: MonoBehaviour {

public void about(){
		Application.LoadLevel("about");

	}

public void play(){

		Application.LoadLevel("Level_1");
	}

	public void exit(){
		Application.Quit();
	}
}
