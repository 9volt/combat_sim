using UnityEngine;
using System.Collections;

public class GUI_script : MonoBehaviour {
	public Ship_go target;
	public Texture img1;
	public Texture img2;
	public Texture lcanon;
	public Texture rcanon;
	public Texture helm;
	public Texture eng;
	public Texture healthcolor1;
	public Texture healthcolor2;
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
		GUI.DrawTexture(new Rect(50,220,100,100), lcanon);
		GUI.DrawTexture(new Rect(255,220,100,100), rcanon);
		GUI.DrawTexture(new Rect(55,20,100,100), eng);
		
		//GUI.Box(new Rect(10,10,400,400),"" );
		GUI.Box(new Rect(10,10,200,200),"" ); //top left
		GUI.Box(new Rect(210,10,200,200), helm); //top right
		GUI.Box(new Rect(210,210,200,200),"" ); //bottom right
		GUI.Box(new Rect(10,210,200,200),"" ); //bottom left
		
		//Healthbars
		GUI.DrawTexture(new Rect(50,150,target.max_health_e,20), healthcolor1);
		GUI.DrawTexture(new Rect(50,150,target.health_e,20), healthcolor2);
	
		GUI.DrawTexture(new Rect(50,350,target.max_health_lc,20), healthcolor1);
		GUI.DrawTexture(new Rect(50,350,target.health_lc,20), healthcolor2);
		
		GUI.DrawTexture(new Rect(250,350,target.max_health_rc,20), healthcolor1);
		GUI.DrawTexture(new Rect(250,350,target.health_rc,20), healthcolor2);
		
		GUI.DrawTexture(new Rect(250,150,target.max_health_h,20), healthcolor1);
		GUI.DrawTexture(new Rect(250,150,target.health_h,20), healthcolor2);
		
		
		if(GUI.Button(new Rect(210,140,60,70), img1)) {
			target.Turn_Ship(1);
		}
		if(GUI.Button(new Rect(350,140,60,70), img2)) {
			target.Turn_Ship(1);
		}
    }
}   