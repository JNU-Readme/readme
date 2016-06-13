using UnityEngine;
using System.Collections;

namespace wm
{
    public class Obstacle : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision) // 충돌
        {
            Vector3 direction = transform.position - collision.gameObject.transform.position;
            direction = direction.normalized * 300;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
        }


        float height = -0.02f;
        float angle = 0.7f;
        // Use this for initialization
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {// 실린더 상하운동 , 실린더 회전운동
         //실린더 상하운동
            float newYPosition = transform.localPosition.y + height;
            transform.localPosition = new Vector3(transform.localPosition.x,
                newYPosition,
                transform.localPosition.z);
            if (transform.localPosition.y < -0.2)
            {
                height = 0.02f;
            }
            else if (transform.localPosition.y > 1.5)
            {
                height = -0.02f;
            }
            //실린더 회전운동
            float newYRotation = transform.localEulerAngles.y + angle;
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,
                newYRotation,
                transform.localEulerAngles.z);

        }
    }
}
