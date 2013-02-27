//Justin White jrw152
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	GameObject playerChar;
	public Vector3 jumpVelocity;
	public float jumpStrength=-.5f;
	public int maxJumps=4;
	int currentJumps =10;
	GameObject jBox;
	numJumps nj;
	int minValueForRecharge=1;
	//bool leftArrow=false;
	//bool rightArrow=false;
	// Use this for initialization
	void Start () {
	FindPlayerChar();
	jBox=GameObject.Find("NumberOfJumps");
	nj=(numJumps)jBox.GetComponent("numJumps");
	nj.UpdateNumJumps(currentJumps);
	}
	
	// Update is called once per frame
	void Update () {
	FindPlayerChar();
	
	//		if(Input.GetButtonDown("Jump"))
	//		{
	//		rigidbody.AddForce (jumpVelocity,ForceMode.VelocityChange);	
	//		}
	//Decided that only way to move the main character is through the use of the right click to aim jump mechanic	
	//if (leftArrow==true || Input.GetKeyDown(KeyCode.LeftArrow))
	//	{
	//	leftArrow=true;
	//	playerChar.transform.Translate (new Vector3(-1,0,0));	
	//	}
		
	//if (rightArrow==true || Input.GetKeyDown(KeyCode.RightArrow))
	//	{
	//	rightArrow=true;
			
	//	playerChar.transform.Translate (new Vector3(1,0,0));
			
	//	}
		
	//if (Input.GetKeyUp(KeyCode.LeftArrow))
	//	{
	//	leftArrow=false;
	//	}
		
	//if (Input.GetKeyUp(KeyCode.RightArrow))
	//	{
	//	rightArrow=false;		
	//	}
	//float z1=0;
		if (currentJumps>0)
		{
			
			if (Input.GetButtonDown("Fire1")) {
	            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				//Vector3 dirOfClick=(ray.GetPoint.transform.position);
				
				float xLocation=playerChar.transform.position.x-ray.GetPoint(0).x;
				float yLocation=playerChar.transform.position.y-ray.GetPoint (0).y;
				Vector3 targetVelocity=new Vector3(jumpStrength*(xLocation/* - playerChar.transform.position.x*/) , jumpStrength*(yLocation/* - playerChar.transform.position.y*/), 0f);
				//Debug.Log(xLocation + " " + yLocation);
				rigidbody.AddForce (targetVelocity,ForceMode.VelocityChange);
				
				currentJumps=currentJumps-1;
				nj.UpdateNumJumps(currentJumps);
				//playerChar.transform.Translate (-xLocation, -yLocation, 0 );
			}
		}
			var vel = rigidbody.velocity;
			float speed=vel.magnitude;
			if (speed < minValueForRecharge && currentJumps < maxJumps)
			{
			currentJumps++;	
			nj.UpdateNumJumps(currentJumps);
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
		//onPlatform=true;
	}
	void OnCollionExit(){
		//onPlatform=false;
	}
}
