using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float speed = 5;
    public KeyCode downKey;
    public KeyCode upKey;
    public KeyCode resetKey = KeyCode.Space;
    public float resetPos;
    Rigidbody2D platform;

    // Start is called before the first frame update
    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move platform when keys pressed
        if (Input.GetKey(upKey))
        {
            platform.MovePosition(platform.position + new Vector2(0, speed) * Time.fixedDeltaTime);
            platform.SetRotation(0);
        }
        if (Input.GetKey(downKey))
        {
            platform.MovePosition(platform.position + new Vector2(0, -speed) * Time.fixedDeltaTime);
            platform.SetRotation(0);
        }
        if (Input.GetKey(resetKey))
        {
            Reset();
        }
    }
    //resets position and rotation
    public void Reset()
    {
        platform.MovePosition(new Vector2(resetPos, 0));
        platform.SetRotation(0);
    }
}
