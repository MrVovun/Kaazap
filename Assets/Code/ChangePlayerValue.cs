using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangePlayerValue : MonoBehaviour {

	public int currentValue;
	[SerializeField]
	private GameObject myText;

	private void Start () {
		currentValue = 0;
	}

	private void Update () {
		myText.GetComponent<TextMeshProUGUI> ().text = "Player score: " + currentValue;
	}

	public void UpdateCurrentValue (int cardValue) {
		currentValue = currentValue + cardValue;
	}
}
