using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class gameController : MonoBehaviour
    {
        public MainMenuState mainMenuState;

        void Start()
        {
            mainMenuState.gameObject.SetActive(true);
        }
    }
}

