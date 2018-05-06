using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menumanage : MonoBehaviour {
    public Text highscore;
	// Use this for initialization
	void Start () {
        highscore.text = "High Score: "+PlayerPrefs.GetInt("high").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     public void startgame()
    {
        SceneManager.LoadScene("menu");
    }
}
