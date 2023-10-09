using System.Collections;
using System.Collections.Generic;
using TestXlab;
using UnityEngine;

namespace Golf
{
    public class levelController : MonoBehaviour
    {
        // вызываем кадение камней проигрышь
        public Spawner spawner;
        public bool isGameOver = false;
        public byte rangeA;
        public byte rangeB;

        void Start()
        {
            StartCoroutine(Waiting());
        }

        public IEnumerator Waiting()
        {
            do
            {
                float range = Random.Range(rangeA, rangeB);
                yield return new WaitForSeconds(range);
                spawner.Spawn();
            }
            while (!isGameOver);
        }
    }
}