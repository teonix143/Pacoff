using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {

	public Renderer rend;
	public bool backtoMainMenu;
	public bool backPlayMenu;
	public bool backLevelMenu;


	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	}
	void OnMouseEnter(){
		rend.material.color = Color.yellow;
	}

	void OnMouseExit(){
		rend.material.color = Color.white;
	}
	
	void OnMouseDown(){
		if (backtoMainMenu) 
		{
			Application.LoadLevel (0);
		} 
		else if (backPlayMenu) 
		{
			Application.LoadLevel (1);
		}
		else if (backLevelMenu) 
		{
			Application.LoadLevel (3);
		}
	}
}
