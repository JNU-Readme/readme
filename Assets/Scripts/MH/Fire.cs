using UnityEngine;
using System.Collections;
namespace MH
{
    public class Fire : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            Vector3 direction = transform.position - collision.gameObject.transform.position;
            direction = direction.normalized * 500;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}