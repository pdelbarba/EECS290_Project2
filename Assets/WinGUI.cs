//Brian DelBarba bpd23
using UnityEngine;
using System.Collections;

public class WinGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void showYouWin()
	{
		guiText.enabled = true;
		guiText.text = "YOU WIN";
	}
}
