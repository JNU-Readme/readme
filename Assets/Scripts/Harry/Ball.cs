using UnityEngine;
using System.Collections;

namespace Harry
{
    public class Ball : MonoBehaviour
    {
        float startingPoint;
        public float jumpForce = 350f;
        private bool grounded = false;
        private bool jump;
        Rigidbody rigdbody;
        public float speed = 6f;

        private Vector3 prevPosition;
        private Vector3 prevDiff;
        
        void Awake()
        {
            rigdbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 diff = transform.position - prevPosition;
            if (diff.x != 0 || diff.z != 0 || prevDiff == null)
            {
                prevDiff = diff;
            }

            float angleY = Mathf.Atan2(diff.x, diff.z) * 180 / Mathf.PI;
            float z = 0;
            float x = 0;

            CheckGround();
            if (Input.GetButtonDown("Jump") && grounded)
                jump = true;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (diff.x == 0 && diff.z == 0 && prevDiff != null)
                {
                    diff = prevDiff;
                }

                z = (Mathf.Cos((angleY - 90) * Mathf.PI / 180)) / 2;
                x = (Mathf.Sin((angleY - 90) * Mathf.PI / 180)) / 2;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (diff.x == 0 && diff.z == 0 && prevDiff != null)
                {
                    diff = prevDiff;
                }
                
                z = (Mathf.Cos((angleY + 90) * Mathf.PI / 180)) / 2;
                x = (Mathf.Sin((angleY + 90) * Mathf.PI / 180)) / 2;
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                z = +(Mathf.Cos(angleY * Mathf.PI / 180));
                x = +(Mathf.Sin(angleY * Mathf.PI / 180));
                //GetComponent<Rigidbody>().AddForce(diff * speed);
            }
            if (Input.GetKey(KeyCode.DownArrow)) //감속
            {
                z = -(Mathf.Cos(angleY * Mathf.PI / 180));
                x = -(Mathf.Sin(angleY * Mathf.PI / 180));
                //GetComponent<Rigidbody>().AddForce(diff * -1);
            }

            GetComponent<Rigidbody>().AddForce((new Vector3(x, 0, z) * speed) + diff);

            prevPosition = transform.position;

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