using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Golf
{

    public class TouchObjects : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        private int score = 0;
        Operation op = Add;

        private bool isActive = true;
        private GameObject other;

        public float forceRock; // скорость броска камня
        Vector3 Lastpos; // позиция для последнего кадра
        

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "Rock")
            {
                other = collision.transform.gameObject;
                HitRock();
                //if (!isActive) return;
                //isActive = false;
                int i = op(score, 1);
                scoreText.text = "Score: " + i;

                Debug.Log("Hit! ");
            }
        }

        static int Add(int x, int y) => x + y;

        void HitRock()
        {
            other.GetComponent<Rigidbody>().velocity = transform.forward * forceRock;
        }

        delegate int Operation(int x, int y);
    }
}

