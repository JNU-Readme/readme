using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    float startingPoint;
    //bool ballSpeed;
    //bool isforward;
    // Use this for initialization
  

    void Start () {
                    
        startingPoint = transform.position.z;
           }
 
	// Update is called once per frame
	void Update () {
        //float distance;
        //distance = transform.position.z - startingPoint;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 200);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 200);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);
        }
    }

}
