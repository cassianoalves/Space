using UnityEngine;
using System.Collections;

namespace ui  {
	public class Templates {
		public static bool backToMainButton() {
			return GUI.Button(util.Screen.newScreenRelativeRect(0.0,0.0,0.2,0.1), i18n.Message.get("Main Menu"));
		}

		public static bool pauseButton() {
			return GUI.Button(util.Screen.newScreenRelativeRect(0.0,0.0,1.0/16.0,1.0/16.0), i18n.Message.get("||"));

		}
	}
}
