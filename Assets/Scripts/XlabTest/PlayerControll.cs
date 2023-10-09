using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestXlab
{
    public class PlayerControll : MonoBehaviour
    {
        
        public CloudController cloudController;
        public Change changeWeapon;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Z");
                cloudController.Action();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space");
                changeWeapon.Changeweapons();
            }
        }
    }
}


