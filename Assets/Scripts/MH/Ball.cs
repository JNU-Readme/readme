using UnityEngine;
using System.Collections;

namespace MH
{
    public class Ball : MonoBehaviour
    {
        float startingPoint;
        public float jumpForce = 350f;
        private bool grounded = false;
        private bool jump;
        Rigidbody rigdbody;
        public float speed = 6f;

        void Awake()
        {
            rigdbody = GetComponent<Rigidbody>();
        }
      
        // Update is called once per frame
        void Update()
        {         
            CheckGround(); 
            if (Input.GetButtonDown("Jump") && grounded)
                jump = true;           
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow)) //감속
            {
                GetComponent<Rigidbody>().AddForce(Vector3.back * 1);
            }

        }     
        void FixedUpdate()
        {
            if (jump)
            {
                rigdbody.AddForce(new Vector3(0f, jumpForce, 0f));
                //rigdbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                jump = false;
                GetComponent<AudioSource>().Play();
            }

            
        }
        
       

        void CheckGround()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.9f))
            {
                if (hit.transform.tag == "GROUND")
                {
                    grounded = true;
                    return;
                }
            }
            grounded = false;
        }

    }

}