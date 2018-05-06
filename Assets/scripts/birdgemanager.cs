using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdgemanager : MonoBehaviour {

    public GameObject[] bridge;
    private float spawn = -90.0f;
    private float lenth = 90.0f;
    public int amountbridge = 5;

    private GameObject[] bridgelist = new GameObject[6];
    int listcounter = 0;

    private Transform playertrans;
	// Use this for initialization
	void Start () {
        playertrans = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < amountbridge;i++)
        {
            spawnbridge();
        }

    }
	
	// Update is called once per frame
	void Update () {
		if(playertrans.position.z<(spawn+( amountbridge -1)* lenth))
        {
            deletebridge();
            spawnbridge();
            
        }
	}

    private void spawnbridge()
    {
        int random = Random.Range(0, bridge.Length);


        GameObject go;
        go = Instantiate(bridge[random]) as GameObject;
        go.transform.position = new Vector3(-12, 0, spawn);
        spawn = spawn - lenth;


        if(listcounter< amountbridge)
        {
            bridgelist[listcounter] = go;
            listcounter++;
        }
       
    }

    private void deletebridge()
    {
        DestroyObject(bridgelist[0]);
        for (int i = 0; i < amountbridge; i++)
        {
            bridgelist[i] = bridgelist[i + 1];
        }
        listcounter--;
    }
}
