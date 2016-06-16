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

            if (diffBallPosition.z != 0)
            {
                angleX += Mathf.Atan2(diffBallPosition.y, diffBallPosition.z) / Mathf.PI;
            }
            if (diffBallPosition.z != 0)
            {
                angleY += Mathf.Atan2(diffBallPosition.x, Mathf.Abs(diffBallPosition.z)) * 180 / Mathf.PI;
            }
            if (diffBallPosition.x != 0)
            {
                angleZ += Mathf.Atan2(diffBallPosition.y, diffBallPosition.x) * 180 / Mathf.PI;
            }

            if (angleY > 0)
            {
                positionX -= Mathf.Abs(Mathf.Sin(angleY * Mathf.PI / 180) * cameraZXLen);
                positionZ -= Mathf.Abs(Mathf.Cos(angleY * Mathf.PI / 180) * cameraZXLen);
            }
            else if (angleY < 0)
            {
                positionX += Mathf.Abs(Mathf.Sin(angleY * Mathf.PI / 180) * cameraZXLen);
                positionZ -= Mathf.Abs(Mathf.Cos(angleY * Mathf.PI / 180) * cameraZXLen);
            }
            else
            {
                positionZ -= cameraZXLen;
            }

            if (angleX > 0)
            {
                positionY += Mathf.Abs(Mathf.Sin(angleX * Mathf.PI / 180) * cameraYZLen);
            }
            else if (angleX < 0)
            {
                positionY += Mathf.Abs(Mathf.Sin(angleX * Mathf.PI / 180) * cameraYZLen);
            }
            else
            {
                positionZ += cameraYZLen;
            }

            transform.position = new Vector3(positionX, positionY, positionZ);
            transform.eulerAngles = new Vector3(angleX, angleY, 0);

            prevBallPosition = ball.transform.position;
        }
    }
}
