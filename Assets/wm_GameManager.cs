using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wm_GameManager : MonoBehaviour {
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
        //Application.LoadLevel("Game");
        SceneManager.LoadScene("MH_Game");
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
