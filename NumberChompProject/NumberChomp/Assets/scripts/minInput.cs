using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class minInput : MonoBehaviour {

	public static int correct;

	
	
	
	void Start ()
	{
		
		//leaf = GameObject.Find(mouseDetect.thisLeaf);
		//anim = leaf.GetComponent<Animator>();
		
		
		var input = gameObject.GetComponent<InputField>();
		var se = new InputField.SubmitEvent();
		se.AddListener(SubmitAnswer);
		input.onEndEdit = se;
		
		
		correct = 0;

		
		//input.onEndEdit.AddListener(SubmitName);  // This also works
	}
	
	private void SubmitAnswer(string arg0)
	{

		
		if (arg0 == minuteQs.numCheck.ToString())
		{
			Debug.Log (minuteQs.numCheck.ToString());
			correct++;
		
		}
		
		this.GetComponent<InputField>().text = string.Empty;
		minuteQs.newQ = true;
		
	}
}
