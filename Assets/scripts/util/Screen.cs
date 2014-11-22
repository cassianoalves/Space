using UnityEngine;
using System.Collections;

namespace util {
	public class Screen {
		public Screen () {
		}

		public static UnityEngine.Rect newScreenRelativeRect(double x, double y, double w, double h) {
			int ix, iy, iw, ih;
			ix = (int)(UnityEngine.Screen.width * x);
			iy = (int)(UnityEngine.Screen.height * y);
			iw = (int)(UnityEngine.Screen.width * w);
			ih = (int)(UnityEngine.Screen.height * h);

			return new UnityEngine.Rect (ix, iy, iw, ih);
		}

	}
}

