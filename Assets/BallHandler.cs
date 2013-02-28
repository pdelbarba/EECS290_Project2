//Brian DelBarba bpd23
using UnityEngine;
using System.Collections;

public class BallHandler : MonoBehaviour {
	public GameObject sphere;
	const float spawnInterval = 40;
	int i = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(i % spawnInterval < 1)
			Instantiate (sphere, new Vector3(-41.5f, 121.0f, 0), Quaternion.identity);
		i++;
		/*if(Collision.GameObject.name == "KillZone") {
			//Destroy ();
			Debug.Log("destroyed");
			//ball.transform.position = new Vector3(-41.5f, 117.0f, 0.0f);
		}*/
	}
}
