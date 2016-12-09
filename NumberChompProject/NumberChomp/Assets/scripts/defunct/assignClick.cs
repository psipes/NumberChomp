using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class assignClick : MonoBehaviour {
	public Button abutton;
	public Button bButton;
	public Text btnTxt;
	public Text probTxt;




	public void OnClick ()
	{
		//textChange.problem.text = btnTxt.text;
		probTxt.text = btnTxt.text;
			bButton.GetComponent<Button>().interactable = false;
		//print(btnTxt.text);
		
		
	
		
	}

}
