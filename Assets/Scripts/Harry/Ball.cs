using UnityEngine;
using System.Collections;

namespace Harry
{
    public class Ball : MonoBehaviour
    {
        float startingPoint;
        //bool ballSpeed;
        //bool isforward;
        // Use this for initialization


        void Start()
        {

            startingPoint = transform.position.z;
        }

        // Update is called once per frame
        void Update()
        {
            //float distance;
            //distance = transform.position.z - startingPoint;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.left * 5);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.right * 5);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.forward * 5);
            }
        }

    }

}