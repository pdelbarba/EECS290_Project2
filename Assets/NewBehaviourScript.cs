//Justin White jrw152
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	GameObject playerChar;
	public Vector3 jumpVelocity;
	bool leftArrow=false;
	bool rightArrow=false;
	bool onPlatform;
	// Use this for initialization
	void Start () {
	FindPlayerChar();
	}
	
	// Update is called once per frame
	void Update () {
	FindPlayerChar();
		if(onPlatform && Input.GetButtonDown("Jump"))
		{
		rigidbody.AddForce (jumpVelocity,ForceMode.VelocityChange);	
		onPlatform=false;
		}
	if (leftArrow==true || Input.GetKeyDown(KeyCode.LeftArrow))
		{
		leftArrow=true;
		playerChar.transform.Translate (new Vector3(-1,0,0));	
		}
		
	if (rightArrow==true || Input.GetKeyDown(KeyCode.RightArrow))
		{
		rightArrow=true;
			
		playerChar.transform.Translate (new Vector3(1,0,0));
			
		}
		
	if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
		leftArrow=false;
		}
		
	if (Input.GetKeyUp(KeyCode.RightArrow))
		{
		rightArrow=false;		
		}
	float z1=0;
		if (Input.GetButtonDown("Fire1")) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Vector3 dirOfClick=(ray.GetPoint.transform.position);
			
			int xLocation=(int)(playerChar.transform.position.x-ray.GetPoint(0).x);
			int yLocation=(int)(playerChar.transform.position.y-ray.GetPoint (0).y);
		
			playerChar.transform.Translate (-xLocation, -yLocation, 0 );
		}
	}
	void FindPlayerChar()
	{
		if(playerChar == null)
		{
			playerChar = GameObject.Find("MainCharacter");	
		}
	}
	void OnCollisionEnter()
	{
		onPlatform=true;
	}
	void OnCollionExit(){
		onPlatform=false;
	}
}
