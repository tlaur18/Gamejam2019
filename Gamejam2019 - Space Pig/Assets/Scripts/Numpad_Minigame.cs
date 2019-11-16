using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numpad_Minigame : MonoBehaviour
{
    private Rigidbody ps;
    private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // Check input for player
        if (Input.GetKey(KeyCode.A))
        {
            // Go left
            ps.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Go right
            ps.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            // Go right
            ps.AddForce(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Go right
            ps.AddForce(Vector3.down * speed);
        }
    }
}

