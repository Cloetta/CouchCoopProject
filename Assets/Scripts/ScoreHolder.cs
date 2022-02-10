using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{
    private GameManager gameManager;
    public int playerOneScore;
    public int playerTwoScore;

    
    public Text txtPlayerOneName;
    public Text txtPlayerTwoName;

    public Text txtScoreOne;
    public Text txtScoreTwo;


    // Start is called before the first frame update
    void Start()
    {

        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        playerOneScore = 0;
        playerTwoScore = 0;


        txtPlayerOneName.text = gameManager.player1Name;
        txtPlayerTwoName.text = gameManager.player2Name;

    }

    // Update is called once per frame
    void Update()
    {
        txtScoreOne.text = playerOneScore.ToString();
        txtScoreTwo.text = playerTwoScore.ToString();
    }
}
