using UnityEngine;
using System.Collections;

public class FoodResultController : MonoBehaviour {

	[SerializeField]
	private UILabel mealLabel;

	[SerializeField]
	private UILabel calorieLabel;

	[SerializeField]
	private UICheckbox eggCheckbox;

	[SerializeField]
	private UICheckbox hotdogCheckbox;

	[SerializeField]
	private UICheckbox breadCheckbox;

	private float calorieHolder = 0f;

	void Start () {
		SetCalorie ();
		SetMeal ();
		AddListeners ();
	}

	void OnDestroy() {
		RemoveListeners ();
	}

	void AddListeners() {
		eggCheckbox.onStateChange += OnClickEgg;
		hotdogCheckbox.onStateChange += OnClickHotdog;
		breadCheckbox.onStateChange += OnClickBread;
	}

	void RemoveListeners() {
		eggCheckbox.onStateChange += OnClickEgg;
		hotdogCheckbox.onStateChange += OnClickHotdog;
		breadCheckbox.onStateChange += OnClickBread;
	}

	void UpdateCalorieLabel() {
		calorieLabel.text = "Calories: " + calorieHolder.ToString ();
	}

	void SetCalorie() {
		calorieHolder = PlayerPrefs.GetFloat ("Calories");
		UpdateCalorieLabel ();
	}

	void SetMeal() {
		mealLabel.text = PlayerPrefs.GetString("Meal");
	}

	void OnClickEgg(bool c) {
		if (c)
			calorieHolder += 15f;
		else
			calorieHolder -= 15f;
		UpdateCalorieLabel ();
	}

	void OnClickHotdog(bool c) {
		if (c)
			calorieHolder += 20f;
		else
			calorieHolder -= 20f;
		UpdateCalorieLabel ();
	}

	void OnClickBread(bool c) {
		if (c)
			calorieHolder += 10f;
		else
			calorieHolder -= 10f;
		UpdateCalorieLabel ();
	}

}
