using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laiser : MonoBehaviour {
	private int valor;
	private float tempoLaiser;
	private bool acionaLaiser;
	public GameObject[] laisers;
	// Use this for initialization
	void Start () {
		tempoLaiser = 0.5f;
		valor = laisers.Length;
	}
	
	// Update is called once per frame
	void Update () {
		
		tempoLaiser -= Time.deltaTime;
		
		if(tempoLaiser <= 0){
			tempoLaiser = 0.5f;
			
			if(!acionaLaiser && valor >= 0 && valor <= laisers.Length){
				valor-=1;
				laisers[valor].SetActive(false);
			}else if(acionaLaiser && valor <= laisers.Length && valor >=0){
				laisers[valor].SetActive(true);
				valor++;
			}
			if(valor >= laisers.Length){
				acionaLaiser = false;
			}	
			if(valor <= 0){
				acionaLaiser = true;
			}
	
		}
		
		

	}
}
