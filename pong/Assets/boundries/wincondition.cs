using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wincondition : MonoBehaviour
{
    [SerializeField] private Transform Ball;
    [SerializeField] private Transform startingpos;
    public GameObject ball;



    void OnTriggerEnter2D(Collider2D other)
    { 
        Ball.transform.position = startingpos.transform.position;
        ball.GetComponent<Circlemovement>().Reset();
    }

    void Update()
    {
     
            
        
    }
}


    
