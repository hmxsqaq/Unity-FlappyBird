using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ProtagonistController : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;
    public float velocity = 5.0f;
    public GameObject Exit;
    private int score = 0;
    private void Start()
    {
        this.GetComponentInChildren<Animator>().SetInteger("states", 1);
        rigidbody2D = this.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, velocity);
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, rigidbody2D.velocity.y * 8);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Score")
        {
            score += 1;
            DataOperate.Instance.Score = score;
        }
        else
        {
            DataOperate.Instance.Diepos = transform.position;
            Exit.GetComponent<SceneSwitch>().SwitchScene();
        }
    }

    public void fly(InputAction.CallbackContext ctx)
    {
        if(ctx.phase == InputActionPhase.Performed)
        {
            rigidbody2D.velocity = new Vector2(0, velocity);
        }
    }

}
