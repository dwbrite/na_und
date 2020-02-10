using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AssemblyCSharp {

	public class GameController : MonoBehaviour {
		
		public Text promptText;

		private PromptManager availablePrompts;
		private Prompt currentPrompt;
		private int currentSeriousness; // from 0 to 5 (exclusive)

		void Start () {
			availablePrompts = new PromptManager ();
			this.currentSeriousness = 0;
			DisplayPrompt ();
		}

		// displays a new random prompt on the screen
		public void DisplayPrompt () {
			currentPrompt = availablePrompts.GetRandomPrompt (currentSeriousness);
			promptText.text = currentPrompt.GetText ();
		}
			
	}
}
