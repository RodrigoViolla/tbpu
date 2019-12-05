using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {

	public GameObject pause;

	void Update () {
		if (Input.GetButtonDown ("Cancel")) {
			Pause ();
		}
	}

	public void Pause(){
		if (pause.activeSelf) {
			pause.SetActive (false);
			Time.timeScale = 1;
		} else {
			pause.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
