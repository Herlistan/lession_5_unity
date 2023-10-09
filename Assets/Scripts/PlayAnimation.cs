using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PlayAnimation : MonoBehaviour
    {
        public Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }
        public void RunAnim()
        {
            animator.SetTrigger("isTrue");

            animator.SetTrigger("isFalse");
        }
    }
}

