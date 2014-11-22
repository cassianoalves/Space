using UnityEngine;
using System.Collections;

public class GameStateMonitor : MonoBehaviour {

	void OnGUI () {
		GameObject g = GameObject.Find ("Main Camera"); 

		GUI.TextArea (new Rect (10,10,100,90), g.transform.ToString());	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
