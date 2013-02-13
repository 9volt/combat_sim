using UnityEngine;
using System.Collections;

public class Ship_go : MonoBehaviour {
	public int max_health_e = 100;
	public int max_health_lc = 100;
	public int max_health_rc = 100;
	public int max_health_h = 100;
	public int health_e ;
	public int health_lc;
	public int health_rc;
	public int health_h;
	
	// Use this for initialization
	void Start () {
		rigidbody.AddForce(transform.forward  * 55);
		health_e = max_health_e;
		health_lc = max_health_lc;
		health_rc = max_health_rc;
		health_h = max_health_h;
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	
	public void Turn_Ship(int dir){
		rigidbody.AddTorque(0, dir * 3, 0);
	}
}
