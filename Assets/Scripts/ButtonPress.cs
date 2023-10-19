using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Golf
{
    public class ButtonPress : MonoBehaviour
    {
        public PlayerController playerControllerAnim;
        public RotationPlatform rotationPlatform;
        
        private void Check()
        {
            playerControllerAnim.RunAnim();
        }
        public void CalledRotationRight()
        {
            rotationPlatform.RotatationPlatformRight();
        }
        public void CalledRotationLeft()
        {
            rotationPlatform.RotatationPlatformLeft();
        }
    }
}


