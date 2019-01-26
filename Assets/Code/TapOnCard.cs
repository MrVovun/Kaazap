using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TapOnCard : MonoBehaviour {

	[SerializeField]
	private GameObject playerValue;
	[SerializeField]
	private GameObject moveCounter;
	[SerializeField]
	private GameObject myDeck;
	[SerializeField]
	private GameObject cardValueHistory;

	private int thisCardValue;

	public void TapOnThisCard () {
		myDeck.GetComponent<GenerateCardValue> ().GenerateThisCardValue ();
		thisCardValue = myDeck.GetComponent<GenerateCardValue> ().cardValue;
		playerValue.GetComponent<ChangePlayerValue> ().UpdateCurrentValue (thisCardValue);
		cardValueHistory.GetComponent<TextMeshProUGUI> ().text = "Previous value: " + thisCardValue.ToString ();
		UpdateMoves ();
	}

	public void UpdateMoves () {
		moveCounter.GetComponent<MovesCounter> ().MadeAMove ();
	}

}
