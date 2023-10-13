using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform helper;
        public float range = 30f;
        public float speedd = 500f;
        public float power = 20f;

        

        // звтвщить сюда код запуска анмации
        

        // Update is called once per frame
        void Update()
        {

        }
        public void OnCollosoinStick(Collider collider)
        {
            if(collider.TryGetComponent(out Rigidbody body))
            {

            }
        }

    }
}

