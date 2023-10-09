using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Golf
{
    public class ButtonPress : MonoBehaviour
    {
        public PlayAnimation playAnimation;

        public void Check()
        {
            playAnimation.RunAnim();
        }
    }
}


