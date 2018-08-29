using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class load2 : MonoBehaviour {
	
	public Image bar;
	float amount;
	
	// Use this for initialization
	void Start () {
		bar.fillAmount = 0;
		amount = bar.fillAmount;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		StartCoroutine(loadSc());

		
	}

	IEnumerator loadSc(){
		
		yield return new WaitForSeconds(15);
		amount = bar.fillAmount;
		if(amount != 1){
			
			bar.fillAmount += 0.08f * Time.deltaTime;
		}
	}
}
