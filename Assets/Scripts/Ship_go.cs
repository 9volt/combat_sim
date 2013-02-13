using UnityEngine;
using System.Collections;

public class Ship_go : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward  * 55);
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	
	public void Turn_Ship(int dir){
		rigidbody.AddTorque(0, dir * 3, 0);
	}
}
