using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximaFase : MonoBehaviour {

	public string proximaFase;
	public GameObject proximaFaseUI;

	void Start(){
		Time.timeScale = 1;
	}

	private void TrocarFase(){
		PlayerPrefs.SetInt (proximaFase, 1);
		proximaFaseUI.SetActive (true);
		Time.timeScale = 0;
	}

	public void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "Player")
			TrocarFase ();
	}
}
