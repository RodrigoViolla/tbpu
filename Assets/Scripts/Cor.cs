using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cor : MonoBehaviour {

	public MudaCorNave nave;

	private Image img;
	private Color32 cor;

	public void SelecionaCor(){
		PlayerPrefs.SetString ("NaveCustom", nave.modelo+";"+cor.r+";"+cor.g+";"+cor.b);
		nave.cor = cor;
	}

	void Start () {
		img = GetComponent<Image> ();
		cor = img.color;
	}
}
