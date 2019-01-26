using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCardValue : MonoBehaviour {

	[SerializeField]
	private string CardType;
	public int cardValue;

	private void Start () {
		GenerateThisCardValue ();
	}

	public void GenerateThisCardValue () {
		if (CardType == "Minus") {
			cardValue = -Random.Range (1, 10);
		} else {
			cardValue = Random.Range (1, 10);
		}
	}

}
