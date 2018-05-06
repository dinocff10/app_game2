using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchthing : MonoBehaviour {
    
    public score sco;
    public menucontrol menucon;

	// Use this for initialization
	void Start () {
        sco = GameObject.FindGameObjectWithTag("Player").GetComponent<score>();
       GameObject menu = GameObject.FindGameObjectWithTag("endmenu");
        menucon =menu.transform.GetChild(1).GetComponent<menucontrol>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("LOSE");
        menucon.toggleend(sco.sco);
    }
   
}
