using UnityEngine;
using System.Collections;

public class FoodUIController : MonoBehaviour {

	[SerializeField]
	private HeavyGutsButton breakfastButton;

	[SerializeField]
	private HeavyGutsButton lunchButton;

	[SerializeField]
	private HeavyGutsButton dinnerButton;

	void Start () {
		AddListener ();
	}

	void OnDestroy() {
		RemoveListener ();
	}

	void AddListener() {
		breakfastButton.AddListener (OnClickBreakfast);
		lunchButton.AddListener (OnClickLunch);
		dinnerButton.AddListener (OnClickDinner);
	}

	void RemoveListener() {
		breakfastButton.RemoveListener (OnClickBreakfast);
		lunchButton.RemoveListener (OnClickLunch);
		dinnerButton.RemoveListener (OnClickDinner);
	}

	void OnClickBreakfast() {
		PlayerPrefs.SetString ("Meal", "Breakfast");
		PlayerPrefs.Save ();
		Application.LoadLevel("FoodResult");
	}

	void OnClickLunch() {
		PlayerPrefs.SetString ("Meal", "Lunch");
		PlayerPrefs.Save ();
		Application.LoadLevel("FoodResult");
	}

	void OnClickDinner() {
		PlayerPrefs.SetString ("Meal", "Dinner");
		PlayerPrefs.Save ();
		Application.LoadLevel("FoodResult");
	}
}
