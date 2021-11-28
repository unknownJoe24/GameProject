using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code to change values of variables from other classes: https://answers.unity.com/questions/42843/referencing-non-static-variables-from-another-scri.html


public class glitch : MonoBehaviour
{
    public GameObject player;
    playerControls playerScript;

    public float randomTimeMax = 50; //max time for random effect to occur
    public float randomTimeMin = 0; //min time for random effect to occur
    public float randomTime;
    public float effectTime = 5;

    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<playerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive) //only randomly apply effect if not already in effect
        { 
            randomTime = Random.Range(randomTimeMin, randomTimeMax);
            effectTime = 5;
        }

        if (isActive)
        {
            effectTime -= Time.deltaTime;
        }

        if (randomTime < 3 && randomTime > 2)
        {
            isActive = true;
            playerScript.jumpSpeed = 50.0f;
            if(effectTime <= 0)
            {
                playerScript.jumpSpeed = 5.0f;
                isActive = false;
            }
        }

        if (randomTime < 5 && randomTime > 4)
        {
            isActive = true;
            playerScript.speed = 50.0f;
            if(effectTime <= 0)
            {
                playerScript.speed = 5.0f;
                isActive = false;
            }
        }
    }

}
