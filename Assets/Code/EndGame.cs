using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	[SerializeField]
	private GameObject gameOverUI;

	public void GameOver () {
		gameOverUI.SetActive (true);
		StartCoroutine ("WaitForRestart");
	}

	private IEnumerator WaitForRestart () {
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}
}
