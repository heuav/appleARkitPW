using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingScript : MonoBehaviour {


	public float Scale = 1f;


	// Update is called once per frame
	void Update () {

		transform.localScale = new Vector3 (Scale, Scale, Scale);

	}

	public void AdjustScale(float newScale){

		Scale = newScale;
		
	}
		
}
