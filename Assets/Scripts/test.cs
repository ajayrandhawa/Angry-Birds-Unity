
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour
{


	public GameObject Bird;
	public int birdcount = 2;
	public int curbird;

	public int friendbird ;

	// Use this for initialization
	void Start ()
	{

		friendbird = 0;
		curbird = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(curbird == 1){
			GameObject.Find("1").GetComponent<Image>().enabled = false;
		}
		if(curbird == 2){
			GameObject.Find("2").GetComponent<Image>().enabled = false;
		}

		if(curbird > 2){
			StartCoroutine(loadSc());
		}
		
		if(friendbird > 2){
			
			StartCoroutine(loadnew());
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (curbird <= birdcount) {
			Destroy (other.gameObject,8);
			StartCoroutine(birdload());
			++curbird;


		} 



	}

	IEnumerator birdload(){
		yield return new WaitForSeconds(5.0f);
		GameObject birdaction = (GameObject)Instantiate (Bird);

	}

	public void birdvoid(){

		friendbird = friendbird + 1;
		Debug.Log(friendbird);

	}

	IEnumerator loadSc(){

		yield return new WaitForSeconds(5);
	Application.LoadLevel ("failed");
		Debug.Log("Level.Fail");
	}

	IEnumerator loadnew(){
		
		yield return new WaitForSeconds(5);
		Application.LoadLevel ("goto2");
		Debug.Log("Level.done");
	}
}
