using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fase : MonoBehaviour {

	private Text fase;
	private Button button;

	void Start () {
		fase = GetComponentInChildren<Text> ();
		button = GetComponent<Button> ();

		if (PlayerPrefs.GetInt (fase.text) == 1 || fase.text == "Plumbus C-137") 
			button.interactable = true;
		else
			button.interactable = false;
	}
}
