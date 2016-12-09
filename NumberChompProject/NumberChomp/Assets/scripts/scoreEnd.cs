using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreEnd : MonoBehaviour {
	
	public Text congrats;
	public GameObject fly;
	
	private Animator anim;
	// Use this for initialization
	void Start () {
	congrats.text = ("You answered " + minScore.score.ToString () + " in a minute!");
	anim = fly.GetComponent<Animator>();
	
	if (minScore.score > 40)
	{
		anim.SetInteger ("buttCh", 5);
	}
	if (minScore.score > 30 && minScore.score < 41)
	{
		anim.SetInteger ("buttCh", 4);
	}
	if (minScore.score > 20 && minScore.score < 31)
	{
		anim.SetInteger("buttCh", 3);
	}
	if (minScore.score > 10 && minScore.score < 21)
	{
		anim.SetInteger("buttCh", 2);
	}
	if (minScore.score < 11)
	{
		anim.SetInteger ("buttCh", 1);
	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
