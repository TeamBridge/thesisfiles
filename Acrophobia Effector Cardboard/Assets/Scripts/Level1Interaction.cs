﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Level1Interaction : MonoBehaviour {
	
	public float gazeTime = 2.0f;

	private float timer;

	private bool gazedAt;

	public GameObject Level1;

	public GameObject Level2;

	public GameObject Level3;

	public GameObject Level4;

	public GameObject Level5;

	public GameObject remarks;

	private int Level1anxiety;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(gazedAt){
			timer += Time.deltaTime;

			if(timer >= gazeTime){
				ExecuteEvents.Execute (gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
				timer = 0f;
			}
		}
	}

	public void PointerClick(){

		if(Level1.name=="AnxietyLevel1"){
			Level1.SetActive (true);
			Level2.SetActive (false);
			Level3.SetActive (false);
			Level4.SetActive (false);
			Level5.SetActive (false);
			Level1anxiety = 1;
		}
	}
}
