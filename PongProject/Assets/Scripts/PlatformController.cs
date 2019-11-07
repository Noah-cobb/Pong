using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float speed = 5;
    public KeyCode DownKey;
    public KeyCode UpKey;
    Rigidbody2D platform;

    // Start is called before the first frame update
    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpKey))
        {
            platform.MovePosition(platform.position + new Vector2(0, speed) * Time.fixedDeltaTime);
        }
        if (Input.GetKey(DownKey))
        {
            platform.MovePosition(platform.position + new Vector2(0, -speed) * Time.fixedDeltaTime);
        }
    }
}
