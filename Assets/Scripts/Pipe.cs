using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float pipe_speed = 2.0f;

    void FixedUpdate()
    {
        if (transform.position.x < -3.8)
        {
            Destroy(this.gameObject);

        }
        transform.Translate(Vector2.left * Time.deltaTime * pipe_speed);
    }
}
