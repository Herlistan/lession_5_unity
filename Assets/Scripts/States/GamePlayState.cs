using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Golf
{
    public class GamePlayState : GameState
    {
        public levelController LevelController;
        public PlayerController playerController;
        public GameState gameOverState;
        public GameState gameWinState;
        public TMP_Text scoreText;
        public TMP_Text LoseText;
        public float WinScore;

        public TMP_Text[] text;

        int numberLetter;
        private void Start()
        {
            TimerEvent.TimeIsOver.AddListener(OnGameOver);
            scoreText.text = $"Score: {LevelController.score} / {WinScore}";
        }
        private void RandNum()
        {
            numberLetter = Random.Range(0, text.Length);
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            LevelController.enabled= true;
            playerController.enabled= true;

            GameEvent.onCollisionStones += OnGameOver;
            GameEvent.onStickHit += OnStickHit;
        }
        private void OnStickHit()
        {
            scoreText.text = $"Score: {LevelController.score} / {WinScore}";
        }
        private void OnGameOver()
        {
            RandNum();
            playerController.OnUP();
            Exit(); // выключаем себя
            if(LevelController.score >= WinScore)
            {
                gameWinState.Enter();
            }
            else
            {
                LoseText.text = text[numberLetter].text;
                gameOverState.Enter();
            }
            
        }

        protected override void OnDisable()
        {
            base.OnDisable();

            GameEvent.onCollisionStones -= OnGameOver;

            LevelController.enabled = false;
            playerController.enabled = false;
        }
    }
}
