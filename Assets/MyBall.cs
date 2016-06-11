using UnityEngine;
using System.Collections;

public class MyBall : MonoBehaviour {
    public float speed = 3f;
    public float jumpPower = 5f;

    Rigidbody rigdbody;

    Vector3 movement;
    float horizontalMove;
    float verticalMove;
    bool isJumping;
    
    
    void Awake()
    {
        rigdbody = GetComponent<Rigidbody>();
    }
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Jump"))
            isJumping = true;
        
		}
    void FixedUpdate()
    {
        Run();
        Jump();
 
    }
    void Run()
    {
        movement.Set(horizontalMove, 0, verticalMove);
        movement = movement.normalized * speed * Time.deltaTime;
        rigdbody.MovePosition(transform.position + movement);
    }
   
    void Jump()
    {
        if (!isJumping)
            
            return;
        rigdbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        isJumping = false;    
     }
   
}
