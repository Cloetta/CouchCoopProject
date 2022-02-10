using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   
    public Text txtCooldown;

    public bool isCountdown = false;
    public float countdownTimer = 60f;


    void Awake()
    {
        //buttonOnKey = GetComponent<Button>();

    }

    private void Start()
    {
        //txtCooldown.gameObject.SetActive(false);
        //imgCooldown.fillAmount = 0f;
    }


    void Update()
    {
        GameCountdown();
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            countdownTimer = 60f;

        }


        if (isCountdown == false)
        {
            //stop time and pop up message: time's up!

            //loadscene p1 or p2 win, check if we need the condition here or later
        }



    }

    void GameCountdown()
    {
        //Subtrack time since last called
        countdownTimer -= Time.deltaTime;

        //Condition to make the text and the filler of the image active according to the status of the skill
        if (countdownTimer <= 0.0f)
        {
            isCountdown = false;

            //txtCooldown.gameObject.SetActive(false);
            //imgCooldown.fillAmount = 0.0f;
        }
        else
        {
            txtCooldown.text = Mathf.RoundToInt(countdownTimer).ToString();
            //txtCooldown.text = cooldownTimer.ToString();
            //imgCooldown.fillAmount = cooldownTimer / skill.skillCooldown;
        }

    }
}
