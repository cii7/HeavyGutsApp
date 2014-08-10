using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	//SerializeField -> private means serializing the variable in order
	// for you to see the variable in the editor without
	// exposing it from other scripts.

	[SerializeField]
	private HeavyGutsButton startButton;

	[SerializeField]
	private HeavyGutsButton aboutButton;

	[SerializeField]
	private HeavyGutsButton tipsButton;

	[SerializeField]
	private HeavyGutsButton triviasButton;

	void Start () {
		AddListeners ();
	}

	void OnDestroy() {
		RemoveListeners ();
	}

	void AddListeners() {
		startButton.AddListener (OnClickStart);
		aboutButton.AddListener (OnClickAbout);
		tipsButton.AddListener (OnClickTips);
		triviasButton.AddListener (OnClickTrivias);
	}

	void RemoveListeners() {
		startButton.RemoveListener (OnClickStart);
		aboutButton.RemoveListener (OnClickAbout);
		tipsButton.RemoveListener (OnClickTips);
		triviasButton.RemoveListener (OnClickTrivias);
	}

	void OnClickStart() {
		Application.LoadLevel("Calorator");
	}

	void OnClickAbout() {
		Debug.Log("You Clicked About!");
	}

	void OnClickTips() {
		Debug.Log("You Clicked Tips!");
	}

	void OnClickTrivias() {
		Debug.Log("You Clicked Trivias!");
	}

}
