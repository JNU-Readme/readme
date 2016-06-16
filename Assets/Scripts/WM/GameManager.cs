using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace wm
{
    public class GameManager : MonoBehaviour
    {
        public int coinCount = 0;
        public Text coinText;


        void GetCoin()
        {
            coinCount++;
            coinText.text = coinCount + "개";
            //Debug.Log("동전: " + coinCount);
        }

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
