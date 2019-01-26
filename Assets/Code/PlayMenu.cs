using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour {

	[SerializeField]
	private GameObject rulesScreen;

	public void PlayGame () {
		SceneManager.LoadScene ("DefaultScene", LoadSceneMode.Single);
	}

	public void QuitGame () {
		Application.Quit ();
	}

	public void ShowRules () {
		rulesScreen.SetActive (true);
	}

	public void HideRules () {
		rulesScreen.SetActive (false);
	}
}
