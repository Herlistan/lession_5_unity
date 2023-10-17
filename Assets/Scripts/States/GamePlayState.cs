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
        public TMP_Text scoreText;
        public TMP_Text LoseText;

        public TMP_Text[] text;

        int numberLetter;

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
            scoreText.text = $"Score: {LevelController.score}";
        }
        private void OnGameOver()
        {
            RandNum();
            LoseText.text = text[numberLetter].text;
            Exit(); // ��������� ����
            gameOverState.Enter();
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
