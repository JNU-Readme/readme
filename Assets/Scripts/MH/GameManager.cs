using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MH
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
            
                SceneManager.LoadScene("MH_Game");
        
            
        }
        public void FinishPoint()
        {
            SceneManager.LoadScene("windmill");
        }
        void HiddenStageStart()
        {
            DestoryStage();
        }
        void DestoryStage()
        {
            GameObject[] stages = GameObject.FindGameObjectsWithTag("HiddenStage");
            for (int i = 0; i < stages.Length; i++)
            {
                Destroy(stages[i]);
            }

        }

        void RedCoinStart()
        {
            DestoryObstacles();
        }

        void DestoryObstacles()
        {
            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
            for (int i = 0; i < obstacles.Length; i++)
            {
                Destroy(obstacles[i]);
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
