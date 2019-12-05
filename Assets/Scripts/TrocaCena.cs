using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour {

	void Start(){
		Cursor.SetCursor (Resources.Load<Texture2D> ("cursor"), Vector2.zero, CursorMode.Auto);
	}

	public void MudaCena(string cena){
		Time.timeScale = 1;
		SceneManager.LoadScene (cena);
	}
	public void Sair(){
		Application.Quit ();
	}
}
