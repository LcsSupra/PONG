using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayers1 : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.A;
    public KeyCode moveDown = KeyCode.S;
    public float speed = 0.02f;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velo = rb2d.velocity;
        if (Input.GetKey(moveUp))
        {
            velo.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            velo.y = -speed;
        }
        else
        {
            velo.y = 0;
        }
        rb2d.velocity = velo;
    }
}
