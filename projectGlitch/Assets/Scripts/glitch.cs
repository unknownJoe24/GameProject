using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code to change values of variables from other classes: https://answers.unity.com/questions/42843/referencing-non-static-variables-from-another-scri.html
//random time code from https://forum.unity.com/threads/how-to-spawn-at-random-times.1041733/

public class glitch : MonoBehaviour
{
    public GameObject player;
    playerControls playerScript;

    public int randomTimeMax = 100; //max time for random effect to occur
    public int randomTimeMin = 1; //min time for random effect to occur
    public float randomTime;
    public float effectTime = 5;

    private bool isActive = true;

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
            if (effectTime <= 0)
                isActive = false;
        }

        //moonjump glitch
        if (randomTime < 20 && randomTime > 1)
        {
            isActive = true;
            playerScript.jumpSpeed = 15.0f;
            if(effectTime <= 0)
            {
                playerScript.jumpSpeed = 5.0f;
                isActive = false;
            }
        }
        
        //speed up glitch
        if (randomTime < 70 && randomTime > 50)
        {
            isActive = true;
            playerScript.speed = 50.0f;
            if(effectTime <= 0)
            {
                playerScript.speed = 5.0f;
                isActive = false;
            }
        }

        //teleportation glitch
        if(randomTime == 100)
        {
            //teleport player
            transform.position = new Vector3(Random.Range(0, 140), Random.Range(0, 150), 0);
            effectTime = 0;
        }
    }

}
