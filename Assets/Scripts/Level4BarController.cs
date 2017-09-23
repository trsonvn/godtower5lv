﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Level4BarController : MonoBehaviour {

	public Image thisImage;


	void Start(){
		thisImage = GetComponent<Image> ();
	}
	public void OnPointerEnter(){
		Color tempColor = thisImage.color;
		tempColor.a = 0;
		thisImage.color = tempColor;


	}
	public void OnPointerExit(){
		Color tempColor = thisImage.color;
		tempColor.a = 1;
		thisImage.color = tempColor;
	}
}
