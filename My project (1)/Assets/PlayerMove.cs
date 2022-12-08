using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    bool isGrounded; 
    public float groundDrag;
    public float jumpSpeed;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        move = transform.TransformDirection(x,0,z);
        
        if(isGrounded){
            if(Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(transform.up * jumpSpeed, ForceMode.Impulse);
    }
        }
        
        
    }
    private void FixedUpdate()
{
    rb.MovePosition(transform.position + move * speed * Time.fixedDeltaTime);
}
    private void OnCollisionStay(Collision other)
{
    if (other != null)
    {
        isGrounded = true;
    }
}
private void OnCollisionExit(Collision other)
{
    isGrounded = false;
}
}
