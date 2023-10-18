using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        [SerializeField] private RotationPlatform rotationPlatform;

        private void Start()
        {
            animator = GetComponent<Animator>();
            if (animator == null)
            {
                Debug.Log("Animator is Null");
            }
        }
        private void Update()
        {
            
        }
        public void OnUP()
        {
            rotationPlatform.isRotate= false;
        }
        public void OnDown()
        {
            rotationPlatform.isRotate = true;
        }
        public void RunAnim()
        {
            animator.SetTrigger("isTrue");

            animator.SetTrigger("isFalse");
        }
    }
}
