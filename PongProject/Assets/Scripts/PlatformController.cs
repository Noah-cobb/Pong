using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float speed = 5;
    public float sizeReduction = 0.95f;
    public KeyCode downKey;
    public KeyCode upKey;
    public KeyCode resetKey = KeyCode.Space;
    public float resetPos;
    Transform transformer;
    Vector3 currentScale;
    Vector3 origScale;
    Rigidbody2D platform;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    { 
        platform = GetComponent<Rigidbody2D>();
        transformer = GetComponent<Transform>();
        origScale = transformer.localScale;
        currentScale = transformer.localScale;
        audio = GetComponent<AudioSource>();
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
        transformer.localScale = origScale;
        currentScale = origScale;
    }
    //detect ball collide, 
    void OnCollisionEnter2D(Collision2D col)
    {
        //detect collision, reset when collide
        if (col.gameObject.name == "Circle")
        {
            audio.Play();
            currentScale.y = currentScale.y * sizeReduction;
            transformer.localScale = currentScale;
        }
    }
}
