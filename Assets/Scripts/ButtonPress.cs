using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Golf
{
    public class ButtonPress : MonoBehaviour
    {
        public PlayerController playerControllerAnim;

        public void Check()
        {
            playerControllerAnim.RunAnim();
        }
    }
}


