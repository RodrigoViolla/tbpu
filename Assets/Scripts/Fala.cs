using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fala : MonoBehaviour {

	public string texto;
	public float intervalo;

	private int charAtual;
	private float tempoAtual;
	private TextMesh mesh;

	void Start () {
		mesh = GetComponent<TextMesh> ();
		mesh.text += texto [charAtual];
		charAtual++;
	}

	void Update () {

		if (charAtual >= texto.Length) {
			Destroy (gameObject.transform.parent.gameObject);
		}

		if (tempoAtual <= 0 && charAtual < texto.Length) {
			tempoAtual = intervalo;
			if(texto [charAtual] == '?')
				mesh.text += "\n";
			else
				mesh.text += texto [charAtual];

			charAtual++;
		}

		tempoAtual -= Time.deltaTime;
	}
}
