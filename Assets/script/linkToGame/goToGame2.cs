﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goToGame2 : MonoBehaviour {

	public Button btnGoToGame2_cours;

	// Use this for initialization
	void Start () {
		Button btnGame2_cours = GetComponent<Button>();
		btnGoToGame2_cours.onClick.AddListener(LoadGame2_cours);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LoadGame2_cours () {
		SceneManager.LoadScene("Game2_cours");
	}
}
