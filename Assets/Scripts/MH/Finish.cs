using UnityEngine;
using System.Collections;
namespace MH
{
    public class Finish : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "AtomBall")
            {

                GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
                gmComponent.FinishPoint();
            }
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