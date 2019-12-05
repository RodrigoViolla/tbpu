using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraJogador : MonoBehaviour {

	public Transform jogador;

	void Update () {
		transform.position = new Vector3 (jogador.position.x, jogador.position.y, transform.position.z);
	}
}
