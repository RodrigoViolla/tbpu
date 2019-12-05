using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float tempoInicial;

	private float tempoAtualMin;
	private float tempoAtualSeg;
	private Text texto;

	void Start () {
		tempoAtualMin = tempoInicial;
		texto = GetComponent<Text> ();
	}

	void Update () {
		if (tempoAtualMin <= 0 && tempoAtualSeg <= 0)
			SceneManager.LoadScene ("GameOver");

		if (tempoAtualSeg <= 0) {
			tempoAtualSeg = 59;
			tempoAtualMin--;
		}

		tempoAtualSeg -= Time.deltaTime;

		texto.text = ((int)tempoAtualMin) +":"+ ((int)tempoAtualSeg);
	}
}
