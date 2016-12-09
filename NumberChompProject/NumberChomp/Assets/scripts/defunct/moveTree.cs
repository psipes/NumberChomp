using UnityEngine;
using System.Collections;

public class moveTree : MonoBehaviour {
	float moveX;
	float moveY;
	
	// Use this for initialization
	void Start () {
		moveX = transform.position.x;
		moveY = transform.position.y;	
	}
	
	// Update is called once per frame
	void Update () {
	
	if (inputCheck.changeProb == true)
		{

			
			/*print ((moveX) + " " + (moveY));
			transform.position =  new Vector2(moveX--, 0);
			moveX = transform.position.x;
			moveY = transform.position.y;	*/
			transform.Translate(1,0,0);
		}
	}
}
