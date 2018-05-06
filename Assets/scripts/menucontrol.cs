using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class menucontrol : MonoBehaviour {
    public Text scoretext;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toggleend(float score)
    {
        gameObject.SetActive(true);
        scoretext.text = ((int)score).ToString();

        if(PlayerPrefs.HasKey("high"))
        {
            if(PlayerPrefs.GetInt("high")<score)
            {
                PlayerPrefs.SetInt("high", (int)score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("high", (int)score);
        }

    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void tomenu()
    {
        SceneManager.LoadScene("realmenu");
    }
}
