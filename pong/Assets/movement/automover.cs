using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automover : MonoBehaviour
{
    gamemanager Gamemanager;
    void Start()
    {
        GameObject gamecontroller = GameObject.FindGameObjectWithTag("GameController");
        Gamemanager = gamecontroller.GetComponent<gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Gamemanager.MoveVector * Gamemanager.MoveSpeed * Time.deltaTime);
    }
}
