using UnityEngine;
using System.Collections;

public class moveArea : MonoBehaviour {
	public static bool moveable;
	
	void OnMouseEnter()
	{
		moveable = true;
		
	}
	
	void OnMouseExit()
	{
		moveable = false;
	}
	
}