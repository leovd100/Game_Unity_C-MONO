using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private float velocidade;
	private Vector3 posicao;
	// Use this for initialization
	void Start () {
		// Inicia no momento em que é apertado o Play
		velocidade = 5;
		
	}
	
	// Update is called once per frame
	void Update () {
		// É executada a cada frame do jogo
		movimento(velocidade);
		transform.position = delimitar(posicao);

	}

	void movimento(float vel){
		if(Input.GetAxis("Vertical")>0){
			transform.Translate(Vector3.right * vel * Time.deltaTime);
		}
		
		if(Input.GetAxis("Vertical")<0){
			transform.Translate(Vector3.left * vel * Time.deltaTime);
		}

		if(Input.GetAxis("Horizontal") > 0){
			transform.Rotate(0,65 * Time.deltaTime,0);
			//transform.Translate(Vector3.forward * vel * Time.deltaTime);
		}
		if(Input.GetAxis("Horizontal") < 0){
			transform.Rotate(0,-65 * Time.deltaTime,0);
			//transform.Translate(Vector3.forward * -vel * Time.deltaTime);
		}
	}

	private Vector3 delimitar(Vector3 posicao){
			
		posicao = transform.position;

		
		posicao.x = transform.position.x <= -1? -1 : transform.position.x;
		posicao.x = transform.position.x >= 17.65? 17.65f : transform.position.x;
		posicao.z = transform.position.z >= 15? 15 : transform.position.z;
		posicao.z = transform.position.z <= 10.9? 10.9f : transform.position.z;


		return posicao; 




	}


	private void OnTriggerEnter(Collider coll) {
		if(coll.gameObject.tag == "laiser"){
			Spawn.podeSpawnar = true;
			Destroy(gameObject);
		}

	}

}

	
