using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saida : MonoBehaviour {
	public string fase; // pega o nome da fase para ser adicionada


	// Use this for initialization
	private void OnTriggerEnter(Collider coll) {
		if(coll.gameObject.tag == "Player")	{
			 SceneManager.LoadScene(fase);
		}
	}
}
