using UnityEngine;
using System.Collections;

public class MH_RedCoin : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Ball")
        {
            GameObject.Find("GameManager").SendMessage("RedCoinStart");
            Destroy(gameObject);
        }
    }
 
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
