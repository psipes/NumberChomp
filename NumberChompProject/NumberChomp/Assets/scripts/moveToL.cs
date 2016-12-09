using UnityEngine;
using System.Collections;

public class moveToL : MonoBehaviour {
	
	public GameObject bug;
	
	private Animator anim;
	private float speed;
	private Vector3 target;

	// Use this for initialization
	void Start () {
		anim = bug.GetComponent<Animator>();
		speed = 1f;
		target = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
			
		if ((leafCollide.moveit == true)&&(mouseDetect.leafClick == true))
		{
			if (Input.GetMouseButtonDown (0))
			{
					anim.SetInteger("mover", 1);
					speed = 1f;
					target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
					target.z = transform.position.z;
				
			}
			transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
		} else
			{
				speed = 0f;
				anim.SetInteger("mover", 0);
			}
	}
}
