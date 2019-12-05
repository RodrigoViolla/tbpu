using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour {

	public int velocidade;
	public int pulo;
	public float gasto;

	private Rigidbody2D rig;
	private Bateria bateria;
	private RotacaoPlanetas rotacao;
	private Checkpoint checkpoint;

	void Start () {
		rig = GetComponentInChildren<Rigidbody2D> ();
		bateria = GetComponent<Bateria> ();
		checkpoint = GetComponent<Checkpoint> ();
	}

	void Update () {

		if (Time.timeScale == 0)
			return;

		if (bateria.BateriaQuant <= 5)
			return;

        if (Input.GetAxis("Vertical") != 0 && bateria.BateriaQuant>=10) {
            if(Input.GetAxis("Vertical") > 0)
			    rig.AddForce (GetComponentsInChildren<Transform>()[1].up*velocidade);
            else
                rig.AddForce(GetComponentsInChildren<Transform>()[1].up * -velocidade);
            bateria.BateriaQuant -= gasto;
		}
        if (Input.GetAxis("Horizontal") != 0 && bateria.BateriaQuant >= 10)
        {
            if (Input.GetAxis("Horizontal") > 0)
                rig.AddForce(GetComponentsInChildren<Transform>()[1].right * velocidade);
            else
                rig.AddForce(GetComponentsInChildren<Transform>()[1].right * -velocidade);
            bateria.BateriaQuant -= gasto;
        }

        if (Input.GetButtonDown ("Checkpoint")) {
			checkpoint.RetornarParaUltimoCheckpoint ();
		}
	}
}
