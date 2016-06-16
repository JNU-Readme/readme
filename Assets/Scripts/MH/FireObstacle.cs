using UnityEngine;
using System.Collections;
namespace MH
{
    public class FireObstacle : MonoBehaviour
    {
        float delta = -0.1f;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float newXposition = transform.localPosition.x + delta;
            transform.localPosition = new Vector3(newXposition, transform.localPosition.y,
                transform.localPosition.z);
            if (transform.localPosition.x < -3.5)
            {
                delta = 0.1f;
            }
            else if (transform.localPosition.x > 3.5)
            {
                delta = -0.1f;

            }
        }
    }
}