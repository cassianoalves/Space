using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	void OnGUI() {
		GUI.Label (new Rect (10, 10, 100, 20), Screen.width + "x" + Screen.height);

		GUILayout.BeginArea (util.Screen.newScreenRelativeRect(0.2, 0.25, 0.6, 0.5));
		GUILayoutOption[] options = new GUILayoutOption[1];
		options[0] = GUILayout.ExpandHeight(true);

		if(GUILayout.Button (i18n.Message.get("Play"), options)) startGame();
		if(GUILayout.Button (i18n.Message.get("Options"), options)) optionsScreen();

		GUILayout.EndArea ();
	}

	private void startGame() {
		Application.LoadLevel ("sandbox"); // TODO: Open first level or last reached one
	}

	private void optionsScreen() {

		Application.LoadLevel ("Options");
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
