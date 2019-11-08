using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlatformController;

public class BallMove : MonoBehaviour
{
    public float speed = 4;
    public KeyCode startKey = KeyCode.Space;
    public PlatformController[] controllers;
    Rigidbody2D ball;
    Vector2 force;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        // Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(startKey))
        {
            Reset();
        }
        //ball.AddForce(force);
        ball.SetRotation(0);
        ball.velocity = ball.velocity.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.name == "Goal")
        {
            Reset();
            ball.velocity = new Vector2(0, 0);
        }
    }
    public void Reset()
    {
        for(int i = 0; i < controllers.Length; i++)
        {
            controllers[i].Reset();
        }
        Input.GetKey(startKey);
        ball.MovePosition(new Vector2(0, 0));
        ball.velocity = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized * speed;
    }
    
}
