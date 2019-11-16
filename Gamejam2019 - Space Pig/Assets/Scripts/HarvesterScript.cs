using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvesterScript : MonoBehaviour
{
    private Transform transform;
    private Vector3 startingPosition;
    private bool headingRight = true;

    public float range = 40f;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (headingRight)
        {
            transform.position += Vector3.right * speed;
        }
        else
        {
            transform.position += Vector3.left * speed;
        }

        if (transform.position.x > startingPosition.x + range)
        {
            Flip();
        }
        if (transform.position.x < startingPosition.x)
        {
            Flip();
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        headingRight = !headingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
