using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreira : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "Player") {
			coll.GetComponentInParent<Checkpoint> ().RetornarParaUltimoCheckpoint();
		}
	}
}
