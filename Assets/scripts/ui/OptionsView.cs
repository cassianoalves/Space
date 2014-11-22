using UnityEngine;
using System.Collections;

public class OptionsView : MonoBehaviour {

	void OnGUI() {
		if(ui.Templates.backToMainButton()) {
			Application.LoadLevel("main");
		}

		GUI.Label(util.Screen.newScreenRelativeRect(0.4,0.45,0.2,0.1), 
		          i18n.Message.get("Not avaliable yet... :("));

	}

	// Use this for initialization
	void Start () {
		Debug.Log ("Em OptionsView loadedLevelName = " + Application.loadedLevelName);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
