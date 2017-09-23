﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Text hintText;
	public InputField inputField;
	public Text levelText;

	//Normal varitables
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;

	//Use this for initialization




	// Use this for initialization
	void Start () {

		hintText.text = levelHint;
		StartCoroutine (ChangeTextLevelCoroutine ());


		
	}
	IEnumerator ChangeTextLevelCoroutine(){
		while (true) {
			yield return new WaitForSeconds (2f);
			levelText.text = levelNumber;
			yield return new WaitForSeconds (2f);
			levelText.text = "LEVELS";
		}
	}

	public void CheckAnswer(){

		if (inputField.text == levelAnswer){
			//TODO : ChangeScene
			hintText.text = "Chuan CMNR";
			hintText.color = Color.green;

			SceneManager.LoadScene (nextScene);

		} else {
			hintText.text = "Sai CMNR";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
