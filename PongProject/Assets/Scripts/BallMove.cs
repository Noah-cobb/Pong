using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float speed = 4;
    public KeyCode startKey = KeyCode.Space;
    Rigidbody2D ball;
    Vector2 force;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(startKey))
        {
            Reset();
        }
        ball.AddForce(force);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Goal")
        {
            Reset();

        }
    }
    public void Reset()
    {
        ball.MovePosition(new Vector2(0, 0));
        ball.velocity = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized * speed;
    }
    
}
