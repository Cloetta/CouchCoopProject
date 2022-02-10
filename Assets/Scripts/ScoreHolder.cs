using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{

    public int playerOneScore;
    public int playerTwoScore;

    //Names perhaps?
    //public Text txtPlayerOneName;
    //public Text txtPlayerTwoName;

    public Text txtScoreOne;
    public Text txtScoreTwo;


    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txtScoreOne.text = playerOneScore.ToString();
        txtScoreTwo.text = playerTwoScore.ToString();
    }
}
