using UnityEngine;
using System.Collections;

public class leafCollide : MonoBehaviour {
	
	public static bool moveit;
	public GameObject bug;
	
	private Animator anim;
	
	void Start()
	{
		moveit = true;
		anim = bug.GetComponent<Animator>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (moveToNewL.moveTo == false)
		{
			if(col.gameObject.tag == "leafStop")
			{
				moveit = false;
				anim.SetInteger("mover", 0);
				//print ("it hit me!");
				
			}
		}
	
	}
}
