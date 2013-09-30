using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	public float time;
	
	void Start () {
		Destroy(gameObject, time);
	}
	
	
	void FixedUpdate () {
		rigidbody.AddRelativeForce(0,0,250);		
	}
	
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Asteroid"){
			Destroy(gameObject);	
			
			
			for (int i = 0; i < 2; i++) {
			GameObject smallAsteroids = Instantiate(Resources.Load("SmallAsteroids"), col.gameObject.rigidbody.position, transform.rotation) as GameObject;
			}
		}
	}
}
