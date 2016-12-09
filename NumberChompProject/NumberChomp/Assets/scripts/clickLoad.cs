using UnityEngine;
using System.Collections;

public class clickLoad : MonoBehaviour {

	public void LoadScene (int level)
	{
		//loadingImage.SetActive (true);
		Application.LoadLevel (level);
	}
}
