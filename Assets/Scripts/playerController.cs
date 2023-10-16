using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        public Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
            if (animator == null)
            {
                Debug.Log("Animator is Null");
            }
        }
        public void RunAnim()
        {
            animator.SetTrigger("isTrue");

            animator.SetTrigger("isFalse");
        }
    }
}
