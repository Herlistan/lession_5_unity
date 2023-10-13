using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class playerController : MonoBehaviour
    {
        [SerializeField] private Player player;

        private void Start()
        {
            if(player == null)
            {
                Debug.Log("Player is Null");
            }
        }

        void Update()
        {
            if (player == null)
            {
                Input.GetMouseButtonDown(0);
            }
        }
    }
}
