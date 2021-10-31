using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{

    //public Rigidbody rigidbody = GetComponent<Rigidbody>;
    public float speed = 5.0f;
    public float jumpSpeed = 8.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            speed = 10.0f;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift)){
            speed = 5.0f;
        }

        Movement();
    }

    public void Movement(){
        float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");
        float jumpInput = Input.GetAxis("Jump");

        transform.Translate(new Vector2(horizontalInput, jumpInput) * jumpSpeed * Time.deltaTime);
    }
}
