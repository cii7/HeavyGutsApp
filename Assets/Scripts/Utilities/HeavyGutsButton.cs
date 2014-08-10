using UnityEngine;
using System.Collections;
using System;

public class HeavyGutsButton : MonoBehaviour {

	private Action OnClickWithoutParameter;

	public void AddListener(Action callback) {
		OnClickWithoutParameter -= callback;
		OnClickWithoutParameter += callback;
	}

	public void RemoveListener(Action callback) {
		OnClickWithoutParameter -= callback;
	}

	void OnClick () {
		if (OnClickWithoutParameter != null)
			OnClickWithoutParameter ();
	}
}
