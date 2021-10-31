using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glitch : MonoBehaviour
{
    public GameObject player;
    PlayerScript playerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<playerControls>;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            playerScript.jumpSpeed = 300.0f;
        }
    }
}
