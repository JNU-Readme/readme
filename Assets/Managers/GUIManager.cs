using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
    public GUIText GameOverText, InstructionsText, RunnerText;

	// Use this for initialization
	void Start () {
        GameEventManager.GameStart += GameStart;
        GameEventManager.GameOver += GameOver;
        GameOverText.enabled = false;
	}
    private void GameStart()
    {
        GameOverText.enabled = false;
        InstructionsText.enabled = false;
        RunnerText.enabled = false;
        enabled = false;
    }
    private void GameOver()
    {
        GameOverText.enabled = true;
        InstructionsText.enabled = true;
        enabled = true;
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            GameEventManager.TriggerGameStart();
        }
	}
  

}
