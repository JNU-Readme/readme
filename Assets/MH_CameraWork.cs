using UnityEngine;
using System.Collections;

public class CameraWork : MonoBehaviour {
    public GameObject ball;
    
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");






    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(ball.transform.position.x, 
        ball.transform.position.y+3,
        ball.transform.position.z - 14);
        
       
        //transform.rotation = new Quaternion(0, ball.transform.rotation.y, 0,0);
        //transform.LookAt(ball);
    }
}
