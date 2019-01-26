using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointsKeeper : MonoBehaviour {

	public int HP;

	public Image[] heartList;
	public Sprite fullHeart;
	public Sprite emptyHeart;

	[SerializeField]
	private GameObject myText;
	[SerializeField]
	private GameObject gameOverController;

	private void Update () {
		if (HP <= 0) {
			OutOfHP ();
		}
		if (HP > 10) {
			HP = 10;
		}
		for (int i = 0; i < heartList.Length; i++) {
			if (i < HP) {
				heartList[i].sprite = fullHeart;
			} else {
				heartList[i].sprite = emptyHeart;
			}
			if (i < 10) {
				heartList[i].enabled = true;
			} else {
				heartList[i].enabled = false;
			}
		}
	}

	public void DecreaseHP (int minusHP) {
		HP = HP - minusHP;

	}

	public void OutOfHP () {
		gameOverController.GetComponent<EndGame> ().GameOver ();
	}

}
