using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection: MonoBehaviour
{
    public bool p1canPickup = false;
    public bool p2canPickup = false;

    //Scripts objects to get access to other scripts variables
    public Movement playerBoost;
    public ScoreHolder score;


    private void Start()
    {
        playerBoost = GameObject.FindGameObjectWithTag("MovementController").GetComponent<Movement>();
        score = GameObject.FindGameObjectWithTag("MovementController").GetComponent<ScoreHolder>();
    }


    void Update()
    {
        if (p1canPickup == true && Input.GetKeyDown(KeyCode.Keypad1))
        {
            PickUpItem();

            BonusPlayerOne();

            //Possible implementation: text appears on screen for the time of the bonus? try the countdown here to bring the value back to normal again
        }
        else if (p1canPickup == false && Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("P1 not in range");

            //nothing happens
        }


        if (p2canPickup == true && Input.GetKeyDown(KeyCode.E))
        {
            PickUpItem();

            BonusPlayerTwo();
            
            //Possible implementation: text appears on screen for the time of the bonus? try the countdown here to bring the value back to normal again
        }
        else if (p2canPickup == false && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("P2 not in range");


            //nothing happens
        }


    }

    //Check collision with the player to determine if we can interact with the item or not
    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if (collidedObject.tag == "Player1")
        {
            p1canPickup = true;
        }
        else if (collidedObject.tag == "Player2")
        {
            p2canPickup = true;
        }
    }

    //Check collision with the player to determine if we can interact with the item or not
    private void OnTriggerExit2D(Collider2D collidedObject)
    {
        if (collidedObject.tag == "Player1")
        {
            p1canPickup = false;
        }
        else if (collidedObject.tag == "Player2")
        {
            p2canPickup = false;
        }
    }


    public void PickUpItem()
    {
        //Feedback for picking the item
        //FindObjectOfType<AudioSystem>().Play("CollectedItem");

        Debug.Log("Picked up: " + this.name);

        bool pickedUp = true;

        if (pickedUp == true)
        {
            //Object into the environment is destroyed
            Destroy(gameObject);
        }

    }

    void BonusPlayerOne()
    {
        if (gameObject.tag == "Gem")
        {
            score.playerOneScore += 5;
        }
        else if (gameObject.tag == "Coin")
        {
            score.playerOneScore += 2;
        }
        else if (gameObject.tag == "Potion")
        {
            score.playerOneScore -= 3;

            //Check this later on
            //playerBoost.playerOneSpeed += 5;

            //float bonusTime = 4f;

            //bonusTime -= Time.deltaTime;

            //if (bonusTime <= 0.0f)
            //{
            //    playerBoost.playerOneSpeed -= 5f;
            //    Debug.Log("P2 end of bonus: " + playerBoost.playerOneSpeed);
            //}
        }
    }

    void BonusPlayerTwo()
    {
        if (gameObject.tag == "Gem")
        {
            score.playerTwoScore += 5;
        }
        else if (gameObject.tag == "Coin")
        {
            score.playerTwoScore += 2;
        }
        else if (gameObject.tag == "Potion")
        {
            score.playerTwoScore -= 3;

            //Test later on
            //playerBoost.playerTwoSpeed += 5;

            ////this is not working, find out why
            //float bonusTime = 4f;

            //bonusTime -= Time.deltaTime;

            //if (bonusTime <= 0.0f)
            //{
            //    playerBoost.playerTwoSpeed = 5f;
            //}
        }
    }
}
