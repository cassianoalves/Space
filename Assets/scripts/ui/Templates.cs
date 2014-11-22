using UnityEngine;
using System.Collections;

namespace ui  {
	public class Templates {
		public static bool backToMainButton() {
			return GUI.Button(util.Screen.newScreenRelativeRect(0.0,0.0,0.2,0.1), i18n.Message.get("Main Menu"));
		}
	}
}
