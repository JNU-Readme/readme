using UnityEngine;
using System.Collections;

namespace wm
{
    public class CameraWork : MonoBehaviour
    {
        public GameObject ball;


        // Use this for initialization
        void Start()
        {
            ball = GameObject.Find("Ball");

        }
        // Update is called once per frame
        void Update()
        {
            transform.position = new Vector3(ball.transform.position.x,
                                    ball.transform.position.y + 1.16f,
                                    ball.transform.position.z - 4.21f);

            //transform.rotation = new Quaternion(0, ball.transform.rotation.y, 0,0);
            //transform.LookAt(ball);
        }
    }
}
