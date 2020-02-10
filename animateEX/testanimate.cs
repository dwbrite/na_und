using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testanimate : MonoBehaviour {

	public GameObject column;
	public Sprite[] triSheet;

	private float metric;


	// Use this for initialization
	void Start () {

		triSheet = Resources.LoadAll<Sprite>("triSheet1");
		column.GetComponent<SpriteRenderer> ().sprite = triSheet [0];
		
	}
	
	// Update is called once per frame
	void Update () {

		if (metric > 30){
		
			column.GetComponent<SpriteRenderer>().sprite = triSheet[1];
		
		}
		
	}
}
