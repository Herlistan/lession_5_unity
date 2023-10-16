using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameOverState : GameState
    {
        public GameState mainMenuState;
        public levelController LevelController;

        public void Restart()
        {
            LevelController.ClearStone();

            Exit();
            mainMenuState.Enter();
        }
    }
}
