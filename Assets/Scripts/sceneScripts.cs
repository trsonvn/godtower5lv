using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneScripts : MonoBehaviour {


	public string nextScene;

	public void ChangeScene(){
		SceneManager.LoadScene (nextScene);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
