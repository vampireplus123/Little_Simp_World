using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rid;
    private Vector3 moveDir;

    private void Start()
    {
        rid = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            moveY += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX += 1;
        }
        moveDir = new Vector3(moveX, moveY).normalized;

        rid.velocity = moveDir * speed;
    }
}
