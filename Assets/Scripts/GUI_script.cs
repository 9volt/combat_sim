using UnityEngine;
using System.Collections;

public class GUI_script : MonoBehaviour {
	public Ship_go target;
	public Texture img1;
	public Texture img2;
	//public GUISkin myskin;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
		//GUI.skin = myskin;
		//GUI.DrawTexture(new Rect(10,10,60,70), img1);
			
		
		if(GUI.Button(new Rect(20,40,60,70), img1)) {
			target.Turn_Ship(1);
		}
		if(GUI.Button(new Rect(100,40,60,70), img2)) {
			target.Turn_Ship(1);
		}
    }
}   