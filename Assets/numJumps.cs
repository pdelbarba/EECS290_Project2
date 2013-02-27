using UnityEngine;
using System.Collections;

public class numJumps : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateNumJumps(int currentJumps)
	{
		guiText.text="Jumps Left: "+ currentJumps.ToString();	
	}
}
