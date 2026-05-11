using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Variables and Classes

    public float speed = 10f;
    public float pushSpeed = 0f;

    private bool pushing = false;

    public Animator animator;
    private Rigidbody2D rb2d;

    
    //Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get value of horizontal input
        float xInput = Input.GetAxis("Horizontal") * speed;
        
        // Get value of vertical input
        float yInput = pushSpeed;

        // Handle pushing condition
        pushing = Input.GetAxis("Vertical") < 0;

        if (pushing)
        {
            pushSpeed = -15f;
        }
        else
        {
            if (pushSpeed < 0f)
            {
                pushSpeed += 0.1f;
            }
            else
            {
                pushSpeed = 0f;
            }
        }

        // Move sprite using Rigidbody2D
        rb2d.velocity = new Vector2(xInput, yInput);

        // Animate if pushing
        animator.SetBool("Pushing", pushing);
    }
}