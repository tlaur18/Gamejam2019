using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingScript : MonoBehaviour
{
    public float speed = 0.1f;
    public bool m_FacingRight = true;
    public float viewRange = 15;

    public GameObject player;
    Transform transform;

    private bool walking = true;
    private bool noticed = false;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
        Physics2D.IgnoreCollision(transform.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (!walking)
        {
            return;
        }

        var enemyPosition = transform.position;
        var playerPosition = player.transform.position;

        if (Math.Abs(enemyPosition.x - playerPosition.x) > viewRange)
        {
            noticed = false;

            return;
        }

        if (playerPosition.x > enemyPosition.x)
        {
            if (!noticed)
            {
                noticed = true;

                audioSource.Play(0);
            }

            if (m_FacingRight == false)
            {
                Flip();
            }
            transform.position += Vector3.right * speed;
        }
        else
        {
            if (m_FacingRight == true)
            {
                Flip();
            }
            transform.position += Vector3.left * speed;
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.Equals(player))
        {
            walking = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.Equals(player))
        {
            walking = true;
        }
    }
}
