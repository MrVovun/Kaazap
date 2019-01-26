using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRound : MonoBehaviour {

	[SerializeField]
	private GameObject movesKeeper;

	public void TapOnFinishButton () {
		movesKeeper.GetComponent<MovesCounter> ().OutOfMoves ();
	}

}
