using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstRot : MonoBehaviour {
	public float rotacao;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,rotacao * Time.deltaTime,0);
	}
}
