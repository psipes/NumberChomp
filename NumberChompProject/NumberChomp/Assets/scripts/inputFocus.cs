using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class inputFocus : MonoBehaviour {
	public InputField input;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(mouseDetect.leafClick == true)
		{
			//print("true");
			input.ActivateInputField();
		}
	
	}
}
