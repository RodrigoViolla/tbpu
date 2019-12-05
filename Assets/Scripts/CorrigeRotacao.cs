using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrigeRotacao : MonoBehaviour {

	private GameObject target;

	void Update () {
		if (target != null) {
			Vector3 dir = target.transform.position - transform.position;
			float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);		
		} else {
			gameObject.transform.rotation = new Quaternion (0, 0, 0.7f, -0.7f);
		}
	}

	public GameObject Target{
		get{return target;}
		set{target = value;}
	}
}
