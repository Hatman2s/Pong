using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circlemovement : MonoBehaviour
{

    public float speed = 12.0f;
    private bool launched = false;
    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !launched)
        {
            Launch();
        }
      
    }
    private void Launch()
    {
        launched = true;
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }
    public void Reset()
    {
        launched = false;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        

    }
    float HitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.name == "player1")
        {
            FindObjectOfType<Audiomanager>().Play("player1bat");

            float y = HitFactor(transform.position,
                                Col.transform.position,
                                Col.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;


            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }


        if (Col.gameObject.name == "player2")
            {

            FindObjectOfType<Audiomanager>().Play("player2bat");

            float y = HitFactor(transform.position,
                                Col.transform.position,
                                Col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;

        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "leftend")
        {
            FindObjectOfType<Audiomanager>().Play("loosesound");
            scoreboard.instance.Scored(Scorer.AI);
        }
        if (other.tag == "rightend")
        {
            FindObjectOfType<Audiomanager>().Play("winsound");
            scoreboard.instance.Scored(Scorer.Player);
        }
    }
}


 

