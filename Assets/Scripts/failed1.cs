using UnityEngine;
using System.Collections;

public class failed1 : MonoBehaviour {

	public void mainmenu(){
		Application.LoadLevel("Main_menu");
	}
	
	public void reload(){
		Application.LoadLevel("Level_2");
	}
	
	public void gotonext(){
		Application.LoadLevel("end");
	}

	public void end(){
		Application.LoadLevel("end");
	}


}
