using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

	public GameObject destino;
	public float tempo;

	private float tempoAtual;
	private bool ativo = true;

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "Player" && ativo) {
			coll.gameObject.transform.parent.transform.position = destino.transform.position;
			destino.GetComponent<Portal> ().Desativar ();
		}
	}

	void Update(){
		if (tempoAtual > 0)
			tempoAtual -= Time.deltaTime;

		if (tempoAtual <= 0) {
			ativo = true;
		}
	}

	public void Desativar(){
		ativo = false;
		tempoAtual = tempo;
	}
}
