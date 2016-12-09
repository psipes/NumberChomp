using UnityEngine;
using System.Collections;

public class mouseFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//if clickLeaf == false && moving == false
		//if a leaf hasn't been selected and the caterpillar isn't technically moving towards the leaf
		if (moveArea.moveable == true)
		{
				if (mouseDetect.changeLeaf == true)
			{
				Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
			}
		
		//on Click, freeze direction.
		}
	}
}
