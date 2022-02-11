using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public Text playerOneName;
    //public Text playerTwoName;

   
    public static GameManager instance = null;

    public string player1Name;
    public string player2Name;

    public int player1Score;
    public int player2Score;

    
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
 
    }


    void Update()
    {
        
    }
    

    //At the end of the level runs the next scene which will reveal if player one or player 2 is the winner
    void EndLevel()
    {
        //SceneManager.LoadScene("MatchEnd");
    }


    public void OnStartButton()
    {

        SceneManager.LoadScene("Level1");

    }
}



