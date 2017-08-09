using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {


	public float Rotation = 0f;
	Vector3 Point;
	Vector3 axis; 


	// Update is called once per frame
	void Update () {

		transform.RotateAround(Point,axis,Rotation);

	}

	public void AdjustRotation(float newRotation){

		Rotation = newRotation;
		Point = transform.position;
		axis = transform.up;

	}

}