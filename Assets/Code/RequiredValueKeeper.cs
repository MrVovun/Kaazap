using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RequiredValueKeeper : MonoBehaviour {

	public int reqNumber = 20;
	[SerializeField]
	private GameObject myText;

	public void IncreaseReqNumber () {
		reqNumber = reqNumber + 20;
	}
	private void Update () {
		myText.GetComponent<TMP_Text> ().text = "Required " + reqNumber;
	}
}
