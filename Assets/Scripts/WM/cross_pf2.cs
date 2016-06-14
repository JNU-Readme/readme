using UnityEngine;
using System.Collections;
namespace wm
{

    public class cross_pf2 : MonoBehaviour
    {

        // Use this for initialization
        float speed = -0.2f;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float newXPosition = transform.localPosition.x + speed;
            transform.localPosition = new Vector3(
                newXPosition, transform.localPosition.y,
                transform.localPosition.z);
            if (transform.localPosition.x <  - 20)
            {
                speed = 0.2f;
            }
            else if (transform.localPosition.x > + 20)
            {
                speed = -0.2f;
            }
        }
    }
}