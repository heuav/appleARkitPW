using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinganController : MonoBehaviour {

	public float scale = 1f;
	Vector3 point;
	Vector3 axis;

	
	// Update is called once per frame

	void Update () {

		transform.localScale = new Vector3 (scale, scale, scale);
		point = transform.position;	
		axis = transform.up;
	}

	public void adjustScale (float newScale){

		scale = newScale;

	}

	public void RotateClockwise(){

		transform.RotateAround (point, axis, 10);
	}

	public void RotateCounterClockwise(){

		transform.RotateAround (point, axis, -10);

	}
}

