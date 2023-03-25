using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    Vector2 start_pos;
    public float ground_speed = 2.5f;
    void Start()
    {
        start_pos = transform.position;
    }

    void Update()
    {
        if(transform.position.x < -1.6)
        {
            transform.position = start_pos;
        }
        transform.Translate(Vector2.left * Time.deltaTime * ground_speed);
    }
}
