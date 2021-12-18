using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//jump code from https://answers.unity.com/questions/1020197/can-someone-help-me-make-a-simple-jump-script.html
//death and respawn code from https://answers.unity.com/questions/634219/how-do-i-respawn-the-player-after-it-dies.html

public class playerControls : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 10.0f;
    public float dashSpeed = 50.0f;
    public float jumpSpeed = 5.0f;
    public Vector2 jump;
    int deaths;
    GameObject startPosition;

    bool isGrounded;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector2(0.0f, 2.0f);
        startPosition = GameObject.FindGameObjectWithTag("Start Position");
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

        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetButtonDown("Fire3"))
        {
            transform.position = transform.position + new Vector3(horizontalInput * dashSpeed * Time.deltaTime, verticalInput * dashSpeed * Time.deltaTime, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Death" || other.tag == "Enemy")
        {
            //kill player
            deaths++;
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        Debug.Log("dead");
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(5);
        Debug.Log("respawn");
        transform.position = startPosition.transform.position;
        GetComponent<Renderer>().enabled = true;
    }
}
