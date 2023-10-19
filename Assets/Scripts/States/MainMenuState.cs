using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Golf
{
    public class MainMenuState : GameState
    {
        public levelController LevelController;
        public TimerEvent timerEvent;
        public GameState gamePlayState;
        public TMP_Text scoreText;

        public void PlayGame()
        {
            Exit();
            timerEvent.DoTimer();
            gamePlayState.Enter();
        }

        protected override void OnEnable()
        {
            base.OnEnable();

            scoreText.text = $"HScore: {LevelController.hightScore}";
        }
    }
}
