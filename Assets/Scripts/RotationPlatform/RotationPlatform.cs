using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Golf
{
    public class RotationPlatform : MonoBehaviour
    {
        public bool isRotate = false;

        public float RotateY;

        private void Update()
        {
            if (isRotate)
            {
                transform.Rotate(0, RotateY * Time.deltaTime, 0);
            }
        }
        public void RotatationPlatformLeft()
        {
            RotateY = -20;
        }
        public void RotatationPlatformRight()
        {
            RotateY = 20;
        }
    }
}
