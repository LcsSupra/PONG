using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlayers2 : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.P; //Mouvement Haut
    public KeyCode moveDown = KeyCode.L; //Mouvement Bas
    public float speed = 0.02f;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

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
