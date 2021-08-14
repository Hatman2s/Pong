using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2paddle : MonoBehaviour
{

    public Transform target;

    public float speed;

    private void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, target.position.y), step);
    }

}
