using UnityEngine;
using System.Collections;


namespace MH
{
    public class FailZone : MonoBehaviour
    {
      

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "AtomBall")
            {
                
                GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
                gmComponent.RestartGame();
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
