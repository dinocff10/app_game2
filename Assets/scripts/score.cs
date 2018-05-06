using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text txt;
    public float sco;
    private float nextscore = 10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        sco += Time.deltaTime;
        txt.text = ((int)sco).ToString();

        if(sco>=nextscore)
        {
            levelup();
        }

	}

    void levelup()
    {
        nextscore = nextscore * 2;

        GetComponent<playermotor>().setspeed(2);
    }
}
