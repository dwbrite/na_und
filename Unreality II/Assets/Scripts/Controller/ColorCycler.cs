using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCycler : MonoBehaviour {

	public float hueAdjustment;

	private Material material;
	private Color color;

	void Start () {
		Renderer renderer = GetComponent<Renderer> ();
		material = renderer.material;
		color = material.color;
	}

	void Update () {
		float hue;
		float saturation;
		float brightness;

		Color.RGBToHSV (color, out hue, out saturation, out brightness);
		hue += hueAdjustment;
		color = Color.HSVToRGB (hue, saturation, brightness);
		material.color = color;
	}
}
