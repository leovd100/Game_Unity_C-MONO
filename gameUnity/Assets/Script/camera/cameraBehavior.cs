using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehavior : MonoBehaviour {

	// Use this for initialization
	private GameObject player;
	private Vector3 posCam;
	void Start () {
			posCam.y = transform.position.y;
			posCam.z = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag("Player");
		if(player != null){
			
			posCam.x = Vector3.Lerp(transform.position,player.transform.position,1).x + 10;
			transform.position = posCam;
		}
	}
}
