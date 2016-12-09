using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class randomProblem : MonoBehaviour {
	
	public static int first;
	public static int second;
	public static int odd1;
	public static int odd2;
	
	public static bool odd;
	public static bool even;

	public Text problem;
	public Button buttonObj; 

	
	// Use this for initialization
	void Start () {
		
		
		odd = false;
		even = false;
		setProb ();

	}
	
	void Update()
	{
	if (inputCheck.changeProb == true)
	{
		setProb();


	}
	
	}
	
	
	void setProb()
	{
		//public Button buttonObj = GameObject.Find("Button").GetComponent<Button>();
		
		if (buttonObj.GetComponent<Button>().interactable == true)
		{
			if (buttonObj.tag == "bttnOdd" )
			{
				odd1 = Random.Range (0,11);
				odd2 = Random.Range(0,11);
				
				odd = true;
				even = false;
				
				problem.text = (odd1.ToString () + " + " + odd2.ToString ());
			}
			 if (buttonObj.tag == "bttnEven")
			{
				first = Random.Range (0,11);
				second = Random.Range (0,11);
				odd = false;
				even = true;
				
				
				problem.text = (first.ToString () + " + " + second.ToString ());
			}
		}
		inputCheck.changeProb = false;

	}
	
	

	

}
