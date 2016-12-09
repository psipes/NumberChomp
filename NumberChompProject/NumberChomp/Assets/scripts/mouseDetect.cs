using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mouseDetect : MonoBehaviour {
	public Text problem;
	public static bool changeLeaf;
	public static string thisLeaf;
	int num1;
	int num2;
	
	public static int answerCheck;
	public static bool leafClick;
	
	
	
	void Start()
	{
		problem.text = "";
		changeLeaf = true;
		leafClick = false;
	}
	
	
	void OnMouseDown()
	{
		leafClick =true;

		if (changeLeaf == true)
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
			answerCheck = newQ (num1, num2);
			setText (num1, num2);
			changeLeaf = false;
			thisLeaf = this.name;
			//print (thisLeaf);
		}
		
	}
	
	
	
	int newQ(int x, int y)
	{
		if (lvlKeeper.diffLvl<4)
		{
			return x+y;
		}else
		{
			return x*y;
		}
		
	}
	
	
	void setText(int x, int y)
	{
		if (lvlKeeper.diffLvl<4)
		{
			problem.text = (x.ToString() + "+" + y.ToString());
		}else
		{
			problem.text = (x.ToString() + "x" + y.ToString());
		}
	}
	
	

}


