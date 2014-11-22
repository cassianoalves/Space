using UnityEngine;
using System.Collections;

public class GameStateMonitor : MonoBehaviour {

	void OnGUI () {
		GameObject g = GameObject.Find ("Main Camera"); 

		GUI.Label (util.Screen.newScreenRelativeRect(0.0, 0.5, 0.2, 0.5),
		           "Player Pos: " + g.transform.position.ToString());	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
