﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballfactoryScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBall",0f,1f);
        
    }
    void SpawnBall()
    {
        Instantiate(ball, new Vector3(Random.Range(-5f,5f),transform.position.y,transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
