using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawn : MonoBehaviour
{

    public Text txtCooldown;

    public bool isCountdown = false;
    public float countdownTimer = 60f;

    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    // Start is called before the first frame update
    void Start()
    {
        spawnObjects();
    }

    private void Update()
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

    public void spawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int index = 0; index < numberToSpawn; index++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);

            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);


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
