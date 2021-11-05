using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{

    //public Rigidbody rigidbody = GetComponent<Rigidbody>;
    public float speed = 10.0f;
    public float dashSpeed = 20.0f;
    public float jumpSpeed = 8.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>;
    }

    // Update is called once per frame
    void Update()
    {
        

        Movement();
    }

    public void Movement(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float jumpInput = Input.GetAxis("Jump");

        transform.Translate(new Vector2(horizontalInput, 0) * speed * Time.deltaTime);
        transform.Translate(new Vector2(0, jumpInput) * jumpSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(new Vector2(horizontalInput, verticalInput) * dashSpeed * Time.deltaTime);
        }
    }
}
