using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subirDescer : MonoBehaviour {
	private bool cursor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y <= 32.30){
			cursor = false;
		}
		if(transform.position.y >= 35){
			cursor = true;
		}

		if(cursor){
			transform.Translate(0,0, 6 * Time.deltaTime);
		}else{
			transform.Translate(0, 0,-6 * Time.deltaTime);
		}


	}
}
