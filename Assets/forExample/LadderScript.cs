using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LadderScript : MonoBehaviour
{

    private float vertical;
    private float speed = 8f;
    private bool isladder;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D rb;
    // Update is called once per frame
    private void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if (isladder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if(isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 2.5f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        isladder = true;   
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            isladder = false;
            isClimbing = false;
        }   
    }
}
