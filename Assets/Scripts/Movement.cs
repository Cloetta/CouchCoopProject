using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    GameObject playerOne;
    GameObject playerTwo;

    //Rigidbody2D rbodyOne;
    //Rigidbody2D rbodyTwo;


    public float playerOneSpeed;
    public float playerTwoSpeed;



    void Start()
    {
        playerOne = GameObject.FindGameObjectWithTag("Player1");
        playerTwo = GameObject.FindGameObjectWithTag("Player2");

        //rbodyOne = playerOne.GetComponent<Rigidbody2D>();
        //rbodyTwo = playerTwo.GetComponent<Rigidbody2D>();


        playerOneSpeed = 5f;
        playerTwoSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        // ---------------- CLEAN --------------------------------
        //Gets the movement values from manual input
        //Vector2 movementPlayerOne = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //Vector2 movementPlayerTwo = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        //if canmove is true, and movement is not equal to 0, animations are in place


        //This is actually moving the player translating the movement value we stored before to an actual movement
        //rbodyOne.position = rbodyOne.position + movement * Time.deltaTime * playerSpeed;
        //rbodyTwo.position = rbodyTwo.position + movement * Time.deltaTime * playerSpeed;
        //---------------- END CLEAN --------------------------------

        //Player1 movement keys
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerOne.transform.position += Vector3.right * playerOneSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerOne.transform.position += Vector3.left * playerOneSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerOne.transform.position += Vector3.up * playerOneSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerOne.transform.position += Vector3.down * playerOneSpeed * Time.deltaTime;
        }


        //Player2 movement keys
        if (Input.GetKey(KeyCode.D))
        {
            playerTwo.transform.position += Vector3.right * playerTwoSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerTwo.transform.position += Vector3.left * playerTwoSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            playerTwo.transform.position += Vector3.up* playerTwoSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerTwo.transform.position += Vector3.down * playerTwoSpeed * Time.deltaTime;
        }

    }
}
