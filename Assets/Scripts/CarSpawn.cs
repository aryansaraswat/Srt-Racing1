﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject[] cars ;
    int carNo; 
    public float maxPos = 1.27f;
    public float delayTimer = 0.5f;
     public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer; 
    }

    // Update is called once per frame 
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {


            Vector3 carPos = new Vector3(Random.Range(-1.27f, 1.27f), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 7); 
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;

        }
    } 

}
