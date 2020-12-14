using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	private float tempoParaSpawnar;
	static public bool podeSpawnar;

	public GameObject myPlayer;

	// Use this for initialization
	void Start () {
		podeSpawnar = true;
		tempoParaSpawnar = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(podeSpawnar){
		tempoParaSpawnar -= Time.deltaTime;
			if(tempoParaSpawnar <= 0){
				Instantiate(myPlayer,transform.position, Quaternion.identity);
				tempoParaSpawnar = 1;
				podeSpawnar = false;
				
			}
		}

	}








}
