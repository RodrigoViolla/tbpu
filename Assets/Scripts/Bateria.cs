using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bateria : MonoBehaviour {

	public RectTransform bateriaTransform;
	public float reload;

	private float bateriaQuant = 100;

	void Update () {

		if(bateriaQuant < 100)
			bateriaQuant += reload;

		bateriaTransform.anchorMax = new Vector2 (1, bateriaQuant/100);
	}

	public float BateriaQuant{
		set{if (value < 0)
				bateriaQuant = 0;
			else
				bateriaQuant = value;}
		get{return bateriaQuant;}
	}
}
