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

        public Animator animator;
        public float SpeedStep = 0.05f;
        [SerializeField] private float SpeedControl = 1f;


        private Vector3 m_lastPosition;

        void Update()
        {
            m_lastPosition = Helper.position;
        }

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

                    SpeedAnim();
                }
            }
        }
        public void SpeedAnim()
        {
            SpeedControl += SpeedStep;
            animator.SetFloat("SpeedAnim", SpeedControl);

            //SpeedControl = Mathf.Max(0.10f, SpeedControl - SpeedStep);
        }
        public void RestartAnim()
        {
            animator.SetFloat("SpeedAnim", 1f);
            SpeedControl = 1f;
        }
    }
}

