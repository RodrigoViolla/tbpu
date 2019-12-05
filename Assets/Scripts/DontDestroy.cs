using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

	void Awake () {
		if (GameObject.FindObjectsOfType<AudioSource> ().Length > 1) {
			Destroy (gameObject);
		} else {
			DontDestroyOnLoad (gameObject);
		}
	}

	void Update(){
		string cena = SceneManager.GetActiveScene ().name;
		if (cena != "MainMenu" && cena != "CustomScene" && cena != "LevelSelector") {
			Destroy (gameObject);
		}
	}
}
