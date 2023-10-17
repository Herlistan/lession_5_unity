using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class DestroyHouse : MonoBehaviour
    {
        public bool isAfect = false;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Rock")
            {
                if(!this.isAfect)
                {
                    this.GetComponent<Rigidbody>().useGravity = true;
                    this.GetComponent<Rigidbody>().isKinematic = false;
                    this.isAfect= true;
                    GameEvent.StickHit();
                }
            }
        }
    }
}
