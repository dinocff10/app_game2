using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermotor : MonoBehaviour {

    private Rigidbody controller;
    private Vector3 moveVector;

    private float speed = 5.0f;
    private float verticalvelocity = 0.0f;
    private float gravity = 12.0f;
	// Use this for initialization
	void Start () {
        controller = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {


        moveVector = Vector3.zero;

        //X left and right
        moveVector.x = Input.GetAxis("Horizontal")*-speed;


        //觸控螢幕
        if(Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
                moveVector.x = -speed;
            else
                moveVector.x = speed;

        }
        //Y up and down

        //Z forward and back
        moveVector.z = -speed;
        controller.transform.Translate(moveVector * speed * Time.deltaTime);
	}

    public void setspeed(float x)
    {
        speed += x;
    }

  
}
