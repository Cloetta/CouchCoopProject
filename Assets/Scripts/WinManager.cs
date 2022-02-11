using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{

    ScoreSave scoreSave;

    GameObject winOne;
    GameObject winTwo;
    GameObject draft;

    public Text playerOneName;
    public Text playerOneScore;
    public Text playerTwoName;
    public Text plyerTwoScore;

    [SerializeField]
    int playerOnePoints;
    [SerializeField]
    int playerTwoPoints;

    // Start is called before the first frame update
    void Start()
    {
        playerOnePoints = scoreSave.player1Score;
        playerTwoPoints = scoreSave.player2Score;


        winOne = GameObject.FindGameObjectWithTag("Win1");
        winTwo = GameObject.FindGameObjectWithTag("Win2");
        draft = GameObject.FindGameObjectWithTag("Draft");

        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOnePoints > playerTwoPoints)
        {
            winTwo.SetActive(true);
        }
        else if (playerTwoPoints > playerOnePoints)
        {
            winOne.SetActive(true);
        }
        else
        {
            draft.SetActive(true);
        }

    }
}
