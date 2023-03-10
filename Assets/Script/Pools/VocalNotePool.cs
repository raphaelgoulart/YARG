using System.Collections.Generic;
using UnityEngine;

namespace YARG.Pools {
	public class VocalNotePool : Pool {
		public Transform AddNoteInharmonic(float length, float x) {
			var poolable = (VocalNoteInharmonic) Add("note_inharmonic", new Vector3(x, 0.065f, 0.22f));
			poolable.SetLength(length);

			return poolable.transform;
		}

		public Transform AddNoteHarmonic(List<(float, (float, int))> pitchOverTime, float length, float x) {
			var poolable = (VocalNoteHarmonic) Add("note_harmonic", new Vector3(x, 0.065f, 0f));
			poolable.SetInfo(pitchOverTime, length);

			return poolable.transform;
		}

		public Transform AddEndPhraseLine(float x) {
			var poolable = Add("endPhraseLine", new Vector3(x, 0.1f, 0f));
			return poolable.transform;
		}
	}
}