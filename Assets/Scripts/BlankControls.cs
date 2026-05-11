using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLANKControls : MonoBehaviour
{
    // Variables and Classes

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get value of horizontal input
        float xInput = Input.GetAxis("Horizontal") * speed;
        
        // Get value of vertical input
        float yInput = Input.GetAxis("Vertical") * speed;

        // Convert to rounded-down whole numbers
        float wholeX = Mathf.Abs(xInput);
        float wholeY = Mathf.Abs(yInput);

        // Move sprite using x and y coordinate input times speed and deltaTime
        transform.Translate(new Vector2(xInput, yInput) * Time.deltaTime);
    }
}