using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public float health;
	
	void Start () {
		health = 3f;
	}
	
	
	void FixedUpdate () {

		//MOVEMENT 
		if (Input.GetKey(KeyCode.W)){
			rigidbody.AddRelativeForce(new Vector3(0, 0, 7));
		}
		
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate(0, -7, 0);	
		}
		
		else if (Input.GetKey(KeyCode.D)){
			transform.Rotate(0, 7, 0);
		}
		
		//SHOOTING
		if (Input.GetKeyDown(KeyCode.Space)){
			GameObject bullet = Instantiate(Resources.Load("Bullet"), transform.position, transform.rotation) as GameObject;
			
		}
		
		if (Input.GetKeyDown(KeyCode.LeftShift)){
			
			GameObject asteroids = Instantiate(Resources.Load("Asteroids"), new Vector3(Random.Range(-20.0f, 20.0f),2, Random.Range(-15.0f, 15.0f)), Quaternion.identity) as GameObject;
			
		}
	}
}
