using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp {

	public class PlayerController : MonoBehaviour {
		
		public float speed;

		private Rigidbody rb;
		private GameController gameController;

		// Use this for initialization
		void Start () {
			this.rb = GetComponent<Rigidbody> ();
			this.gameController = GameObject.FindWithTag("GameController").GetComponent<GameController> ();
		}
		
		void FixedUpdate () {
			float horizontal = Input.GetAxis ("Horizontal");

			Vector3 movement = new Vector3 (horizontal, 0.0f, 0.0f);
			rb.velocity = movement * speed;
		}

		void OnTriggerEnter(Collider other) {
			if (other.gameObject.CompareTag ("Yes")) {

			} else if (other.gameObject.CompareTag ("No")) {

			} else {

			}

			ResetPosition ();
			gameController.DisplayPrompt ();
		}

		// resets the player position
		void ResetPosition() {
			transform.position = new Vector3 (0, transform.position.y, transform.position.z);
		}
	}
}
