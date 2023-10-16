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
            Exit(); // выключаем себя
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
