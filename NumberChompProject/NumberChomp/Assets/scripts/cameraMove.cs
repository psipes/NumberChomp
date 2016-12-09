using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	//public GameObject bug;
	private Animator anim;
	
	//private float speed;
	
	
	// Use this for initialization
	void Start () {
	anim = GetComponent<Animator>();
	//speed = 0f;
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	switch(answerCh.qCount)
	{
		case 0:
			anim.SetInteger ("qNum", 1);
			answerCh.qCount = 1;
			break;
		case 1:
			anim.SetInteger ("qNum", 1);
			break;
		case 2:
			anim.SetInteger ("qNum", 2);
			break;
		case 3:
			anim.SetInteger("qNum", 3);
			break;
		case 4:
			anim.SetInteger("qNum", 4);
			break;
		case 5:
			anim.SetInteger("qNum", 5);
			break;
		case 6:
			anim.SetInteger("qNum", 6);
			break;
		case 7:
			anim.SetInteger("qNum", 7);
			break;
		case 8:
			anim.SetInteger("qNum", 8);
			break;
		case 9:
			anim.SetInteger("qNum", 9);
			break;
		case 10:
			anim.SetInteger("qNum", 10);
			break;
		case 11:
			anim.SetInteger("qNum", 11);
			break;
		case 12:
			anim.SetInteger("qNum", 12);
			break;		
		case 13:
			anim.SetInteger("qNum", 13);
		break;		
		case 14:
			anim.SetInteger("qNum", 14);
			break;
		default:
			anim.SetInteger ("qNum", 1);
			answerCh.qCount = 1;
			break;
			
		}

	
	}
	

}
