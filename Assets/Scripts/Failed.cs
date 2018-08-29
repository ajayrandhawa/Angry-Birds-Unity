using UnityEngine;
using System.Collections;

public class Failed : MonoBehaviour {
	
	public void mainmenu(){
		Application.LoadLevel("Main_menu");
	}

	public void reload(){
		Application.LoadLevel("Level_1");
	}

	public void gotonext(){
		Application.LoadLevel("Level_2");
	}
}
