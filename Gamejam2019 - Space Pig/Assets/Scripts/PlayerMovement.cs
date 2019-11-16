using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 60f;
    float horizontalMove = 0f;
    bool jump = false;

    //To make sure the player does not move further back than the screen can show
    private float furthedstPlayerXPosition = 0f;
    public float pxlsPlayerIsAllowedToGoBack = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        // Checks if the player is allowed to go further back
        if (gameObject.transform.position.x < furthedstPlayerXPosition - pxlsPlayerIsAllowedToGoBack && horizontalMove < 0)
        {
            horizontalMove = 0;
        }

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

        // Sets the players furthest position it has ever had
        if (gameObject.transform.position.x > furthedstPlayerXPosition)
        {
            furthedstPlayerXPosition = gameObject.transform.position.x;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer.Equals(10))
        {
            SceneManager.LoadScene("Hydroponics");      //TODO - Show death screen or something.
        }

        if (collider.gameObject.layer.Equals(11))
        {
            SceneManager.LoadScene("Numpad_Minigame_loadingscreen");      //TODO - Show death screen or something.
        }
    }
}
