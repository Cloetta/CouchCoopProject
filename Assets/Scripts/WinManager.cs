using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    
    public GameManager gameManager;
    

    public GameObject winOne;
    public GameObject winTwo;
    public GameObject draft;

    public Text playerOneName;
    public Text playerOneScore;
    public Text playerTwoName;
    public Text playerTwoScore;

    [SerializeField]
    int playerOnePoints;
    [SerializeField]
    int playerTwoPoints;

    // Start is called before the first frame update
    void Start()
    {

        //winOne = GameObject.FindGameObjectWithTag("Win1");
        //winTwo = GameObject.FindGameObjectWithTag("Win2");
        //draft = GameObject.FindGameObjectWithTag("Draft");

        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();



        playerOnePoints = gameManager.player1Score;
        playerTwoPoints = gameManager.player2Score;

        playerOneName.text = gameManager.player1Name;
        playerTwoName.text = gameManager.player2Name;

        playerOneScore.text = playerOnePoints.ToString();
        playerTwoScore.text = playerTwoPoints.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if (playerOnePoints > playerTwoPoints)
        {
            winOne.SetActive(true);
        }
        else if (playerTwoPoints > playerOnePoints)
        {
            winTwo.SetActive(true);
        }
        else
        {
            draft.SetActive(true);
        }

    }


    public void LoadLevel()
    {

        SceneManager.LoadScene("Level1");

        Debug.Log("You clicked the button");

    }


}
