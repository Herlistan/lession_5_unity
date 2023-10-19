using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameOverState : GameState
    {
        public GameState mainMenuState;
        public Player player;
        public TimerEvent timerEvent;
        public levelController LevelController;

        public void Restart()
        {
            LevelController.ClearStone();
            player.RestartAnim();
            timerEvent.StopTimer();
            Exit();
            mainMenuState.Enter();
        }
    }
}
