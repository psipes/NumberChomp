using UnityEngine;
using System.Collections;

public class minScore : MonoBehaviour {
	public static int score;
	
	// Use this for initialization
	void Start () {
	score = minInput.correct;
	DontDestroyOnLoad(this.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	score = minInput.correct;
	
	}
}
