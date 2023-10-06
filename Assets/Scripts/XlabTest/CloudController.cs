using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestXlab
{
    public class CloudController : MonoBehaviour
    {
        //[SerializeField] public Transform[] targets2; оно закрыто для изменений из-вне, но при этом можно внести элементы в редакторе!!! 
        public Transform[] targets;

        public float moveSpeed = 1f;
        Vector3 currentVelocity;
        public Transform cloud;

        private bool isRain = false;

        private int m_target_index = 0;
        private bool m_moved = false;

        public void Action()
        {
            Debug.Log("CloudController - Try action!", this);

            if (m_moved)
            {
                return;
            }

            m_moved = true;

            m_target_index++;
            if(m_target_index >= targets.Length)
            {
                m_target_index = 0;
            }
        }

        private void Update()
        {
            if(!m_moved)
            { return; }

            Transform target = targets[m_target_index];
            Vector3 targetPosition = new Vector3(target.position.x, cloud.position.y, target.position.z);
            cloud.transform.position = Vector3.SmoothDamp(cloud.transform.position, targetPosition, ref currentVelocity,  moveSpeed);

            if (Vector3.Distance(cloud.position, targetPosition) < 0.1f)
            {
                m_moved= false;
                isRain = true;
                cloud.GetComponent<Rain>().rain = isRain;
            }
            else
            {
                isRain = false;
                cloud.GetComponent<Rain>().rain = isRain;
            }
        }
    }
}


