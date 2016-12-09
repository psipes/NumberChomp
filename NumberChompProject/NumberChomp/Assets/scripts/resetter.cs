using UnityEngine;
using System.Collections;

public class resetter : MonoBehaviour {

	public static bool reset;
	public static int correct;
	public static string oops;


	// Use this for initialization
	void Start () {
		reset = false;
		correct = correct;
		oops = oops;
	
		DontDestroyOnLoad(this.gameObject);
		
	
	}
	
	// Update is called once per frame
	void Update () {
		print (correct);
		if (reset)
		{
			reset = false;
			correct = answerCh.correct;
			if (lvlKeeper.diffLvl > 1)
			{
				lvlKeeper.diffLvl--;
			}
			
			Application.LoadLevel(2);
			oops = "Oops, Try a new tree!";
		}
		
	
	}
}
