using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class answerCh : MonoBehaviour {

	public Text result;
	GameObject leaf;
	
	Animator anim;
	public static int correct;
	public static int wrong;
	
	public static int qCount;
	
	
	
	void Start ()
	{
		
		//leaf = GameObject.Find(mouseDetect.thisLeaf);
		//anim = leaf.GetComponent<Animator>();
		
		
		var input = gameObject.GetComponent<InputField>();
		var se = new InputField.SubmitEvent();
		se.AddListener(SubmitAnswer);
		input.onEndEdit = se;
		
		correct = resetter.correct;
		result.text = resetter.oops;
		wrong = 0;
		qCount = 1;
		
		
		//input.onEndEdit.AddListener(SubmitName);  // This also works
	}
	
	private void SubmitAnswer(string arg0)
	{
		leaf = GameObject.Find(mouseDetect.thisLeaf);
		anim = leaf.GetComponent<Animator>();
		
		if (arg0 == mouseDetect.answerCheck.ToString())
		{
			Debug.Log (mouseDetect.answerCheck.ToString());
			correct++;
			result.text = "Right!";
			anim.SetInteger("rtWrng", 1);
			qCount++;
			
			if (qCount == 10)
			{
				Application.LoadLevel(3);
			}

			
			
		}
		else
		{
			Debug.Log ("incorrect");
			wrong++;
			result.text = "Wrong";
			anim.SetInteger ("rtWrng", 2);
			qCount++;
			if (wrong == 5)
			{
				result.text = "Oops! He got hungry again!";
				qCount = 0;
				wrong = 0;
				resetter.reset = true;
				//Application.LoadLevel(2);
			}
		}
		if (qCount == 15)
		{
			qCount = 0;
			wrong = 0;
		}
		print (qCount);
		this.GetComponent<InputField>().text = string.Empty;
		mouseDetect.changeLeaf = true;
		mouseDetect.leafClick = false;
		leafCollide.moveit = true;
		moveToNewL.moveTo = true;
		

		
		
		/*changeProb = true;
		randomProblem.odd = false;
		randomProblem.even = false;
		*/
	}
	
}
