using UnityEngine;
using System.Collections;

namespace Harry
{
    public class CameraWork : MonoBehaviour
    {
        public GameObject ball;

        private Vector3 prevBallPosition;
        private float cameraXYLen;
        private float cameraYZLen;
        private float cameraZXLen;


        // Use this for initialization
        void Start()
        {
            prevBallPosition = ball.transform.position;
            Vector3 BallToCamera = ball.transform.position - transform.position;
            cameraXYLen = Mathf.Sqrt(Mathf.Pow(BallToCamera.x, 2) + Mathf.Pow(BallToCamera.y, 2));
            cameraYZLen = Mathf.Sqrt(Mathf.Pow(BallToCamera.y, 2) + Mathf.Pow(BallToCamera.z, 2));
            cameraZXLen = Mathf.Sqrt(Mathf.Pow(BallToCamera.z, 2) + Mathf.Pow(BallToCamera.x, 2));
        }
        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 diffBallPosition = ball.transform.position - prevBallPosition;
            float angleX = 30;
            float angleY = 0;
            float angleZ = 0;

            float positionX = ball.transform.position.x;
            float positionY = ball.transform.position.y;
            float positionZ = ball.transform.position.z;

            angleX += Mathf.Atan2(diffBallPosition.y, diffBallPosition.z) / Mathf.PI;
            angleY += Mathf.Atan2(diffBallPosition.x, diffBallPosition.z) * 180 / Mathf.PI;
            angleZ += Mathf.Atan2(diffBallPosition.y, diffBallPosition.x) * 180 / Mathf.PI;
            
            positionZ -= (Mathf.Cos(angleY * Mathf.PI / 180) * cameraZXLen);
            positionX -= (Mathf.Sin(angleY * Mathf.PI / 180) * cameraZXLen);
            positionY += (Mathf.Sin(angleX * Mathf.PI / 180) * cameraYZLen);
            
            transform.position = new Vector3(positionX, positionY, positionZ);
            transform.eulerAngles = new Vector3(angleX, angleY, 0);

            prevBallPosition = ball.transform.position;
        }
    }
}
