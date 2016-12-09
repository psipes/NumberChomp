using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour 
{

	//float timeLeft = 30.0f;
	public Slider timeL;
	
	void Start () 
	{
		
		timeL.value = timeL.maxValue;
		StartCoroutine ("Countdown", 60);
		
	}
	
	
	void Update()
	{
		//timeL.value = timeL.value;
		//Debug.Log (timeL.value);
		
		/*timeLeft -= Time.deltaTime;
		for (int x = 60; x > 0; x--)
		{
			timeL.text = timeLeft.ToString();
		}
		if(timeLeft < 0)
		{
			Debug.Log ("gameOver");
			//GameOver();
		}
		*/
	}

	
	private IEnumerator Countdown(int time)
	{
		
		while(time>0)
		{
			time--;
			timeL.value = time;
			//timeL.text = time.ToString();
			Debug.Log(timeL.value);
			yield return new WaitForSeconds(1);
		}
		Application.LoadLevel(5);
	}	
}
