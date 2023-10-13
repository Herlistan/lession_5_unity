using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Golf
{
    public class gameState : MonoBehaviour
    {
        public List<GameObject> views;


        private void OnEnable()
        {
            foreach (var item in views)
            {
                item.gameObject.SetActive(true);
            }
        }
        private void OnDisable()
        {
            foreach (var item in views)
            {
                item.gameObject.SetActive(false);
            }
        }
    }
}
