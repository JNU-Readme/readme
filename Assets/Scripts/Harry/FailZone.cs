﻿using UnityEngine;
using System.Collections;

namespace Harry
{
    public class FailZone : MonoBehaviour
    {


        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "AtomBall")
            {
                //GameObject.Find("GameManager").SendMessage("RestartGame");
                //GameObject gm = GameObject.Find("GameManager");
                //GameManager gmComponent = gm.GetComponent<GameManager>();

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
