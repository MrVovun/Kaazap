using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovesCounter : MonoBehaviour {

	public int moves = 5;
	public int currentMoves;
	public int extraMoves;

	[SerializeField]
	private GameObject myText;
	[SerializeField]
	private GameObject reqNumberGO;
	[SerializeField]
	private GameObject playerNumberGO;
	[SerializeField]
	private GameObject hpKeeperGO;

	void Start () {
		currentMoves = moves;
	}

	void Update () {
		if (currentMoves == 0) {
			OutOfMoves ();
		}
		myText.GetComponent<TMP_Text> ().text = "Moves left: " + currentMoves;
	}

	public void UpdateMoves () {
		currentMoves = moves + extraMoves;
		extraMoves = 0;
	}

	public void MadeAMove () {
		currentMoves = currentMoves - 1;
	}

	public void OutOfMoves () {
		if (playerNumberGO.GetComponent<ChangePlayerValue> ().currentValue < reqNumberGO.GetComponent<RequiredValueKeeper> ().reqNumber) {
			int penaltyHP = reqNumberGO.GetComponent<RequiredValueKeeper> ().reqNumber - playerNumberGO.GetComponent<ChangePlayerValue> ().currentValue;
			hpKeeperGO.GetComponent<HealthPointsKeeper> ().HP = hpKeeperGO.GetComponent<HealthPointsKeeper> ().HP - penaltyHP;
		} else if (playerNumberGO.GetComponent<ChangePlayerValue> ().currentValue == reqNumberGO.GetComponent<RequiredValueKeeper> ().reqNumber) {
			extraMoves = extraMoves + 1;
			hpKeeperGO.GetComponent<HealthPointsKeeper> ().HP = hpKeeperGO.GetComponent<HealthPointsKeeper> ().HP + 2;
		} else if (playerNumberGO.GetComponent<ChangePlayerValue> ().currentValue > reqNumberGO.GetComponent<RequiredValueKeeper> ().reqNumber) {
			hpKeeperGO.GetComponent<HealthPointsKeeper> ().OutOfHP ();
		}
		UpdateMoves ();
		reqNumberGO.GetComponent<RequiredValueKeeper> ().IncreaseReqNumber ();
	}
}
