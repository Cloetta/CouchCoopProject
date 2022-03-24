using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNames : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject playerOneInput;
    public GameObject playerTwoInput;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SaveNames()
    {


        gameManager.player1Name = playerOneInput.GetComponent<InputField>().text;
        gameManager.player2Name = playerTwoInput.GetComponent<InputField>().text;


        if (gameManager.player1Name.Length > 5)
        {
            gameManager.player1Name = gameManager.player1Name.Substring(0, 5);
        }

        if (gameManager.player2Name.Length > 5)
        {
            gameManager.player2Name = gameManager.player2Name.Substring(0, 5);
        }

    }


}
