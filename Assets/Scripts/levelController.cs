using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

namespace Golf
{
    public class levelController : MonoBehaviour
    {
        

        public Spawner spawner;

        public bool isGameOver = false;
        public byte rangeMin;
        public byte rangeMax;
        public float rangeStep = 0.1f;
        private float range;

        public int score;
        public int hightScore;

        private float m_lastSpawnedTime = 0;

        private List<GameObject> m_stones = new List<GameObject>(16);

        public void ClearStone()
        {
            foreach(var stone in m_stones)
            {
                Destroy(stone);
            }
            m_stones.Clear();
        }

        void Start()
        {
            m_lastSpawnedTime = Time.time;
            RefreshDelay();

        }
        private void OnEnable()
        {
            GameEvent.onStickHit += OnStickHit;
            score = 0;
        }

        private void OnDisable()
        {
            GameEvent.onStickHit -= OnStickHit;
        }

        private void OnStickHit()
        {
            MathDelegate mathDelegate = Add;
            score = mathDelegate(score, 1);
            hightScore = Mathf.Max(hightScore, score);
            
            Debug.Log($"score {score} - hightscore {hightScore}");
            
        }

        private void Update()
        {
            if (Time.time >= m_lastSpawnedTime + range)
            {
                var stone = spawner.Spawn();
                m_stones.Add( stone );
                m_lastSpawnedTime = Time.time;

                RefreshDelay();
            }

        }
        public void RefreshDelay()
        {
            range = Random.Range(rangeMin, rangeMax);
            range = Mathf.Max(rangeMin, rangeMax - rangeStep);
            
        }
        public static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public delegate int MathDelegate(int value1, int value2);

    }
}