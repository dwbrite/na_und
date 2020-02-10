using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp {
	
	public class PromptManager {

		public static int MAX_SERIOUSNESS = 5;
		List<List<Prompt>> prompts = new List<List<Prompt>> ();
		
		public PromptManager () {
			for (int i = 0; i < MAX_SERIOUSNESS; i++) {
				prompts.Add (new List<Prompt>());
			}

			prompts [0].Add (new Prompt ("Do you drive a car?"));
			prompts [0].Add (new Prompt ("Do you like coffee?"));
			prompts [0].Add (new Prompt ("Do you like art?"));
			prompts [0].Add (new Prompt ("Do you like coffee?"));
			prompts [0].Add (new Prompt ("Do you wear glasses?"));

			prompts [1].Add (new Prompt ("Is taking long showers a waste of waterr?"));
			prompts [1].Add (new Prompt ("Is it okay to lie sometimes?"));

			prompts [2].Add (new Prompt ("Is it okay to eat meat?"));

			prompts [4].Add (new Prompt ("Is killing people okay?"));
		}

		public Prompt GetRandomPrompt (int seriousness) {
			List<Prompt> candidatePrompts = prompts [seriousness];
			System.Random random = new System.Random ();
			int randomIndex = random.Next (candidatePrompts.Count);

			Debug.Log ("index = " + randomIndex);

			Prompt randomPrompt = candidatePrompts [randomIndex];
			candidatePrompts.RemoveAt (randomIndex);

			return randomPrompt;
		}
	}
}

