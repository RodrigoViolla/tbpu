using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotacaoPlanetas : MonoBehaviour {

	public float velocidade;

	void Update () {
		if (Time.timeScale == 0) {
			if(SceneManager.GetActiveScene().name != "MainMenu" && SceneManager.GetActiveScene().name != "LevelSelector" && SceneManager.GetActiveScene().name != "CustomScene" && SceneManager.GetActiveScene().name != "GameOver")
				return;
		}
		transform.Rotate (new Vector3 (0, 0, velocidade));
	}
}
