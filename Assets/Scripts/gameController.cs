using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class gameController : MonoBehaviour
    {
        // Start is called before the first frame update
        // �������� ���� + ��������, ������������ ����

        public MainMenuState mainMenuState;

        void Start()
        {
            mainMenuState.gameObject.SetActive(true);
        }
    }
}

