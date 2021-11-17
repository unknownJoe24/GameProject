using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code to change values of variables from other classes: https://answers.unity.com/questions/42843/referencing-non-static-variables-from-another-scri.html


public class glitch : MonoBehaviour
{
    public GameObject player;
    playerControls playerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<playerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            playerScript.jumpSpeed = 50.0f;
        }

        if (Input.GetButton("Fire2"))
        {
            playerScript.speed = 50.0f;
        }
    }

}
