using UnityEngine;
using System.Collections;

namespace MH
{
    public class Coin : MonoBehaviour
    {
        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.name == "AtomBall")
            {
                GameObject.Find("GameManager").SendMessage("GetCoin");
                Destroy(gameObject);
            }
        }
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, 2.5f));

        }
    }
}
