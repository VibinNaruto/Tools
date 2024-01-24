using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float speed;
private float Move;

public Animator thisAnim;

public float jump;

public bool isJumping;

private Rigidbody rb;

private void Awake()
{
    thisAnim = gameObject.GetComponent<Animator>();
}

    // Start is called before the first frame update
   void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        thisAnim.SetBool("isRunning", Move!=0);

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("jump");
        }
    }
    private void OnCollisionEnter(Collision other)
    {
      if(other.gameObject.CompareTag("Ground"))
      {
        isJumping = false;
      } 
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
