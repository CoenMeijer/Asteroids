using UnityEngine;
using System.Collections;

public class AsteroidsScript : MonoBehaviour {

	
	void Start () {
		transform.Rotate(0,Random.Range(-180,180),0);
	}
	
	void FixedUpdate () {
		transform.Rotate(1, 0, 1);
		rigidbody.AddRelativeForce(Random.Range(-3, 3),0,Random.Range(-3, 3));
	}
	
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Bullet"){
			Destroy(gameObject);
		}	
	}
}
