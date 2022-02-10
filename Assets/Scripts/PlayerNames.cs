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

    }


}
