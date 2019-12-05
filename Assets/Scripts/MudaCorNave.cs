using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudaCorNave : MonoBehaviour {

	public Color32 cor;
	public int modelo;
	public bool inGame;

	public SpriteRenderer rendModelo;
	public Image imgModelo;

	public Sprite[] modelosMascara = new Sprite[0];
	public Sprite[] modelos = new Sprite[0];

	private SpriteRenderer rend;
	private Image img;

	void Start () {
		if (inGame) {
			rend = GetComponent<SpriteRenderer> ();
		} else {
			img = GetComponent<Image> ();
		}

		string[] result = PlayerPrefs.GetString ("NaveCustom").Split(';');

		modelo = int.Parse(result [0]);
		cor = new Color32 (byte.Parse(result [1]), byte.Parse(result [2]), byte.Parse(result [3]), 255);
	}

	void Update () {
		if (inGame) {
			rend.color = cor;
			rend.sprite = modelosMascara[modelo];
			rendModelo.sprite = modelos [modelo];
		} else {
			img.color = cor;
			img.sprite = modelosMascara[modelo];
			imgModelo.sprite = modelos [modelo];
		}
	}

	public void ProximoModelo(){
		if (modelo >= modelosMascara.Length-1) {
			modelo = 0;
		} else {
			modelo++;
		}
		PlayerPrefs.SetString ("NaveCustom", modelo+";"+cor.r+";"+cor.g+";"+cor.b);
	}
	public void ModeloAnterior(){
		if (modelo <= 0) {
			modelo = modelosMascara.Length-1;
		} else {
			modelo--;
		}
		PlayerPrefs.SetString ("NaveCustom", modelo+";"+cor.r+";"+cor.g+";"+cor.b);
	}
}
