using UnityEngine;
using System;
using System.Collections;

public class CaloratorController : MonoBehaviour {

	[SerializeField]
	private HeavyGutsButton maleButton;

	[SerializeField]
	private HeavyGutsButton femaleButton;

	[SerializeField]
	private HeavyGutsButton calculateButton;

	[SerializeField]
	private UIInput nameInput;

	[SerializeField]
	private UIInput ageInput;

	[SerializeField]
	private UIInput heightInput;

	[SerializeField]
	private UIInput weightInput;

	private string genderHolder;
	private string nameHolder;
	private int ageHolder = 0;
	private float heightHolder = 0f;
	private float weightHolder = 0f;

	void Start () {
		AddListeners ();
	}

	void OnDestroy() {
		DestroyListeners ();
	}

	void AddListeners() {
		maleButton.AddListener (OnClickMaleButton);
		femaleButton.AddListener (OnClickFemaleButton);
		calculateButton.AddListener (OnClickCalculate);
	}

	void DestroyListeners() {
		maleButton.RemoveListener (OnClickMaleButton);
		femaleButton.RemoveListener (OnClickFemaleButton);
		calculateButton.RemoveListener (OnClickCalculate);
	}

	void OnClickMaleButton() {
		genderHolder = "Male";
	}

	void OnClickFemaleButton() {
		genderHolder = "Female";
	}

	void OnClickCalculate() {
		SetFieldValues ();
		if (HasCompletedFields ()) {
			PlayerPrefs.SetString("Gender", genderHolder);
			PlayerPrefs.SetString("Name", nameHolder);
			PlayerPrefs.SetInt("Age", ageHolder);
			PlayerPrefs.SetFloat("Height", heightHolder);
			PlayerPrefs.SetFloat("Weight", weightHolder);
			PlayerPrefs.Save ();
			Application.LoadLevel("Results");
		} else 
			Debug.LogError("Not completed");
	}

	private bool HasGender() {
		if (!string.IsNullOrEmpty(genderHolder))
		    return true;
		return false;
	}

	private bool HasName() {
		if (!string.IsNullOrEmpty (nameHolder)) {
			if (!nameHolder.Equals("Enter Name Here"))
				return true;
		}
		return false;
	}

	private bool HasAge() {
		if (ageHolder >= 0)
			return true;
		return false;
	}

	private bool HasHeightOrWeight(float playerHeight) {
		if (playerHeight >= 0f)
			return true;
		return false;
	}

	private bool HasCompletedFields() {
		if (!HasGender ())
			return false;
		if (!HasName ())
			return false;
		if (!HasAge ())
			return false;
		if (!HasHeightOrWeight(heightHolder))
			return false;
		if (!HasHeightOrWeight (weightHolder))
			return false;
		return true;
	}

	private void SetFieldValues() {
		nameHolder = nameInput.text;
		ageHolder = Convert.ToInt32 (ageInput.label.text);
		heightHolder = Convert.ToInt64 (heightInput.label.text);
		weightHolder = Convert.ToInt64 (weightInput.label.text);
	}
}
