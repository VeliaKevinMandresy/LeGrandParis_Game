﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamechooselvl : MonoBehaviour {

    public Button gamebutton;

    // Use this for initialization
    void Start ()
    {
        Button nextscene = gamebutton.GetComponent<Button>();
		nextscene.onClick.AddListener(TaskonClick);
    }	
	// Update is called once per frame
	void Update () {

	}

    public void TaskonClick()
    {
        Debug.Log(this.transform.name);
        if (string.Compare(this.transform.name, "Button_debutant") == 0)
            SceneManager.LoadScene("scene_game1debutant");
    }
}