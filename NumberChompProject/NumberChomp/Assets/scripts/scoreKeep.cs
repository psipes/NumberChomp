using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreKeep : MonoBehaviour {
	
	public Slider hungry;
	//int count;
	

	// Use this for initialization
	void Start () {
		hungry.value = 0;
		//count = 0;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		hungry.value = answerCh.correct;
		//Debug.Log (hungry.value);
		
		if (answerCh.correct == 10)
		{
			//load new scene
			//Debug.Log ("YOU WIN!");
		}
		if (answerCh.wrong == 5)
		{
				
			//load new scene
			//Debug.Log ("YOU LOSE...");
		}
		
	}
}
