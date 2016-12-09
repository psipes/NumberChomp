using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttCam : MonoBehaviour {

	private Animator anim;
	
	public GameObject butt;
	private Animator buttAn;
	
	public Image blk;
	private Animator blkAn;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
		buttAn = butt.GetComponent<Animator>();
		blkAn = blk.GetComponent<Animator>();
		Invoke ("camMove", 2f);
		Invoke ("turn", 3.2f);
		Invoke ("blackOut", 5.2f);
		Invoke ("startOver", 7f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void camMove ()
	{
		anim.SetInteger("mover", 1);
	}
	
	void turn()
	{
		buttAn.SetInteger("toSide", 2);
	}
	
	void blackOut()
	{
		blkAn.SetInteger("blkIt", 1);
	}
	
	void startOver()
	{
		Application.LoadLevel (0);
	}
}
