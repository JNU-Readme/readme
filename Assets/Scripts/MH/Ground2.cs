using UnityEngine;
using System.Collections;

public class Ground2 : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "AtomBall")
        {

            GameObject.Find("GameManager").SendMessage("HiddenStageStart");
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
