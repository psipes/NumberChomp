using UnityEngine;
using System.Collections;

public class lvlKeeper : MonoBehaviour {

	public static int diffLvl;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void diffPick(int x)
	{
	diffLvl = x;
	}
}
