﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public abstract class GameState : MonoBehaviour // этот класс мы можем только наследовать, а сделать экземпляр нет.
    {
        public List<GameObject> views;
        public void Enter()
        {
            gameObject.SetActive(true);
        }

        public void Exit()
        {
            gameObject.SetActive(false);
        }

        protected virtual void OnEnable()
        {
            foreach (var item in views)
            {
                item.SetActive(true);
            }
        }
        protected virtual void OnDisable()
        {
            foreach (var item in views)
            {
                if(item)
                {
                    item.SetActive(false);
                }
            }
        }
    }
}