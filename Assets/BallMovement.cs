using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BallMovement : MonoBehaviour
{
    public TMP_Text p1;
    public TMP_Text p2;
    public float speed = 10;
    public int score_p1;
    public int score_p2;

    void Start()
    {
        score_p1 = 0;
        score_p2 = 0;
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player_1")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (collision.gameObject.name == "player_2")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("goal_1"))
        {
            score_p1++;
            p1.text = "Score :" + score_p1; 
        }
        else if (other.gameObject.CompareTag("goal_2"))
        {
            score_p2++;
        }
    }
}
