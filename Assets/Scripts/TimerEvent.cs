using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Golf
{
    public class TimerEvent : MonoBehaviour
    {
        public static UnityEvent TimeIsOver = new UnityEvent();

        public float timeStart;
        public TMP_Text timerText;
        public bool isTimer = false;

        private void Update()
        {
            if (isTimer && timeStart > 0)
            {
                timeStart -= Time.deltaTime;
                timerText.text = $"Timer: {Mathf.Round(timeStart)}";

                if (timeStart <= 0)
                {
                    isTimer = false;
                    StopGame();
                }
            }
            
        }
        public void DoTimer()
        {
            timeStart = 60f;
            timerText.text = $"Timer: {timeStart}";
            isTimer = true;
        }
        public void StopTimer()
        {
            timeStart = 0f;
            timerText.text = $"Timer: {timeStart}";
            isTimer = false;
        }
        public void StopGame()
        {
            TimeIsOver?.Invoke();
        }
    }
}
