using UnityEngine;

namespace TestXlab
{
    public class Change : MonoBehaviour
    {
        [SerializeField] private MeshFilter[] WhatToChange;
        [SerializeField] private Mesh[] WhatExactlyToChange;
        public int numtool;

        public void Changeweapons()
        {
            Debug.Log(" Changeweapons - Try change!", this);

            for (int i = 0; i < WhatToChange.Length; i++)
            {
                numtool = Random.Range(0, WhatExactlyToChange.Length);
                WhatToChange[i].mesh = WhatExactlyToChange[numtool];
            }
        }
    }
}

