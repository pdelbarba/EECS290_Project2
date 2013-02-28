using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {
	WinGUI wg;
	GameObject wBox;
	// Use this for initialization
	void Start () {
		wBox=GameObject.Find("WinText");
		wg=(WinGUI)wBox.GetComponent("WinGUI");
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * (Time.deltaTime + 6));
	}
	void OnTriggerEnter (Collider other) {
    	Destroy(other.gameObject);
		wg.showYouWin();
	}
}
