using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	public float correcao;

	private Vector3 lastCheckpoint;

	void Start () {
		lastCheckpoint = gameObject.transform.position;
	}

	public Vector3 LastCheckpoint{
		get{ return lastCheckpoint; }
		set{ lastCheckpoint = value; }
	}

	public void RetornarParaUltimoCheckpoint(){		
		gameObject.transform.position = new Vector3 (lastCheckpoint.x, lastCheckpoint.y + correcao, lastCheckpoint.z);
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		GetComponent<Animator> ().SetTrigger ("Morte");
	}
}
