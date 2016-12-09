using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//This script checks to see if the number entered is correct.

public class inputCheck : MonoBehaviour {
	public static bool changeProb = false;


	void Start ()
	{
		var input = gameObject.GetComponent<InputField>();
		var se = new InputField.SubmitEvent();
		se.AddListener(SubmitName);
		input.onEndEdit = se;
		

		//input.onEndEdit.AddListener(SubmitName);  // This also works
	}
	
	private void SubmitName(string arg0)
	{
		if (randomProblem.even == true && randomProblem.odd == false)
		{
			Debug.Log ("even");
			if (arg0 == (randomProblem.first + randomProblem.second).ToString ())
			{
				Debug.Log(arg0);
			} else
			{
				Debug.Log ("incorrect");
			}
		}
		else
		{
			Debug.Log ("odd");
			if (arg0 == (randomProblem.odd1 + randomProblem.odd2).ToString ())
			{
				Debug.Log(arg0);
			} else
			{
				Debug.Log ("incorrect");
			}
		}
		
		
		

		changeProb = true;
		randomProblem.odd = false;
		randomProblem.even = false;

	}

}
