using UnityEngine;
using System.Collections;

public class HudUi : MonoBehaviour {

	void OnGUI() {
		if (ui.Templates.pauseButton ()) {
			Application.LoadLevel("main");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
