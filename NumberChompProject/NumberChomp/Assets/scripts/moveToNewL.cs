using UnityEngine;
using System.Collections;

public class moveToNewL : MonoBehaviour {
	public static bool moveTo;
	bool startMove;
	public GameObject stopHere;
	public GameObject bug;
	Animator anim;
	
	//int trigCount;
	
	

	// Use this for initialization
	void Start () {
	moveTo = false;
	startMove = false;
	//trigCount = 0;
	//speed = 0;
	
	anim = bug.GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (moveTo == true)
		{
			//print ("true");
			anim.SetInteger("mover", 1);
			Invoke ("Moving", 1.2f);
		}else
		{
		//print ("false");
		moveTo = false;
		startMove = false;
		}
	
	}
	
	void Moving()
	{
		
		
		Vector2 moveHere = stopHere.transform.position;
		transform.position = Vector2.Lerp (transform.position, moveHere, 1 * Time.deltaTime);
		startMove = true;
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		
		
		if (startMove == true)
		{
			if (other.gameObject == stopHere)
			{
					
					//anim.SetInteger("mover", 0);
					moveTo = false;
					startMove = false;
				
			}
			
		}
	}
}
