using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class TouchObjects : MonoBehaviour
    {
        private bool isActive = true;
        private GameObject other;

        public float forceRock; // �������� ������ �����
        Vector3 Lastpos; // ������� ��� ���������� �����

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "Rock")
            {
                //GameObject self = gameObject;
                other = collision.transform.gameObject;
                HitRock();
                if (!isActive) return;
                isActive = false;

                Debug.Log("Hit! ");
            }
        }

        void HitRock()
        {
            other.GetComponent<Rigidbody>().velocity = transform.forward * forceRock;
        }
    }
}

