using System;

namespace AssemblyCSharp {
	
	public class Prompt {

		private string text;

		public Prompt (String text) {
			this.text = text;
		}

		public string GetText() {
			return this.text;
		}
	}
}

