using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform Helper;
        public float power = 20f;

        private Vector3 m_lastPosition;

        void Update()
        {
            m_lastPosition = Helper.position;
        }

        /*public void SetDown(bool value)
        {
            
        }*/

        public void OnCollosoinStick(Collider collider)
        {
            if(collider.TryGetComponent(out Rigidbody body))
            {
                var dir = (Helper.position - m_lastPosition).normalized;
                body.AddForce(dir * power, ForceMode.Impulse);

                if(collider.TryGetComponent(out Stone stone) && !stone.isAfect)
                {
                    stone.isAfect= true;
                    GameEvent.StickHit();
                }
            }
        }
    }
}

