using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramotor : MonoBehaviour {

    private Transform lookat;
    private Transform camerafinish;
    private Vector3 offset;
    private Vector3 movevector;

    private float transition = 0.0f;
    private float animationduration = 2.0f;
    private Vector3 animationoffset = new Vector3(0, 20, 5);
    // Use this for initialization
   

    void Start () {
        lookat = GameObject.FindGameObjectWithTag("Player").transform;
        camerafinish = GameObject.FindGameObjectWithTag("Finish").transform;
        offset = transform.position - lookat.position;
        
    }
	
	// Update is called once per frame
	void Update () {

        

        movevector = lookat.position + offset;
        //x
         movevector.x = 0;
        //y

        //z
        transform.position = movevector;


          if(transition>1.0f)
          {
              transform.position = movevector + new Vector3(-10, 5, 0);
          }    
          else
          {
            transform.rotation = Quaternion.Slerp(transform.rotation, camerafinish.rotation , transition/16);
              transform.position = Vector3.Lerp(movevector+ animationoffset, movevector + new Vector3(-10, 5, 0), transition);
              transition += Time.deltaTime * 1 / animationduration;

          }

        
    }
  
}
