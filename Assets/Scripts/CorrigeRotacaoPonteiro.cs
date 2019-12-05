using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrigeRotacaoPonteiro : MonoBehaviour {

	public GameObject target;

	void Update () {
		Vector3 dir = target.transform.position - transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (target.GetComponent<SpriteRenderer> ().isVisible) {
			GetComponentInChildren<SpriteRenderer> ().enabled = false;
		} else {
			GetComponentInChildren<SpriteRenderer> ().enabled = true;
		}
	}
}
