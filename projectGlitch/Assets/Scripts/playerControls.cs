using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//jump code from https://answers.unity.com/questions/1020197/can-someone-help-me-make-a-simple-jump-script.html

public class playerControls : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 10.0f;
    public float dashSpeed = 50.0f;
    public float jumpSpeed = 5.0f;
    public Vector2 jump;

    bool isGrounded;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector2(0.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        

        Movement();
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    public void Movement(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float jumpInput = Input.GetAxis("Jump");

        transform.Translate(new Vector2(horizontalInput, 0) * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetButtonDown("Fire3"))
        {
            transform.Translate(new Vector2(horizontalInput, verticalInput) * dashSpeed * Time.deltaTime);
        }
    }
}
