using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YetiControls : MonoBehaviour
{
    public Animator animator;
    public float speed = 10f;
    
    // Variables and Classes


    // Update is called once per frame
    void Update()
    {
        // Get value of horizontal input
        float xInput = Input.GetAxis("Horizontal") * speed;
        
        // Get value of vertical input
        float yInput = Input.GetAxis("Vertical") * speed;

        // Move sprite using x and y coordinate input times speed and deltaTime
        transform.Translate(new Vector2(xInput, yInput) * Time.deltaTime);
        
        //Set animations using input and animator with Speed condition
        if (Mathf.Abs(xInput) > 0)
        {
            animator.SetFloat("Speed", Mathf.Abs(xInput));
        }
        else
        {
            animator.SetFloat("Speed", Mathf.Abs(yInput));
        }
    }
}