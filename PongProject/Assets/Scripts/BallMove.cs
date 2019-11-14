using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    public float speed = 4;
    public float speedMultiplier = 1.03f;
    //key to reset game state
    public KeyCode startKey = KeyCode.Space;
    public PlatformController[] controllers;
    float currentSpeed;
    Rigidbody2D ball;
    Vector2 force;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        currentSpeed = speed;
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
        ball.velocity = ball.velocity.normalized * currentSpeed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //increase speed
        currentSpeed = currentSpeed * speedMultiplier;
        //detect collision, reset when collide
        if (col.gameObject.name == "Goal")
        {
            Reset();
            ball.velocity = new Vector2(0, 0);
        }
    }
    public void Reset()
    {
        //reset current speed multiplier
        currentSpeed = speed;
        //reset both platforms
        for(int i = 0; i < controllers.Length; i++)
        {
            controllers[i].Reset();
        }
        //reset position, move in random direction
        ball.MovePosition(new Vector2(0, 0));
        ball.velocity = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized * speed;
    }
    
}
