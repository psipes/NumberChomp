using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class minuteQs : MonoBehaviour {

	public Text problem;
	public InputField input;
	
	public static int num1;
	public static int num2;
	public static bool newQ;
	
	public static int numCheck;

	// Use this for initialization
	void Start () {
	
		
		switch (lvlKeeper.diffLvl)
		{
		case 1:
			num1 = Random.Range (0,9);
			num2 = Random.Range (0,9);
			break;
		case 2:
			num1 = Random.Range (0,9);
			num2 = Random.Range (0,99);
			break;
		case 3:
			num1 = Random.Range (0,99);
			num2 = Random.Range (0,99);
			break;
		case 4:
			num1 = Random.Range (0,12);
			num2 = Random.Range (0,12);
			break;
		}
		
		if (lvlKeeper.diffLvl <4)
		{
			numCheck = num1 + num2;
			problem.text = (num1.ToString () + "+" + num2.ToString ());
		} else
		{
			numCheck = num1 * num2;
			problem.text = (num1.ToString () + "x" + num2.ToString ());
		}

	input.ActivateInputField();
	
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	if (newQ)
	{
		
			switch (lvlKeeper.diffLvl)
			{
			case 1:
				num1 = Random.Range (0,9);
				num2 = Random.Range (0,9);
				break;
			case 2:
				num1 = Random.Range (0,9);
				num2 = Random.Range (0,99);
				break;
			case 3:
				num1 = Random.Range (0,99);
				num2 = Random.Range (0,99);
				break;
			case 4:
				num1 = Random.Range (0,12);
				num2 = Random.Range (0,12);
				break;
			}
			
			if (lvlKeeper.diffLvl <4)
			{
				numCheck = num1 + num2;
				problem.text = (num1.ToString () + "+" + num2.ToString ());
			} else
			{
				numCheck = num1 * num2;
				problem.text = (num1.ToString () + "x" + num2.ToString ());
			}
			
		
		newQ = false;
		input.ActivateInputField();
		
	}
	
	
	
	}
	

	
	
	
}
