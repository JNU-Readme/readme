using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace wm
{
    public class GameManager : MonoBehaviour
    {


        public void RestartGame()
        {

            SceneManager.LoadScene("windmill");
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
