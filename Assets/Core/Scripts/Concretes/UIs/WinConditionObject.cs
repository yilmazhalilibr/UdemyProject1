using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;


namespace UdemyProject1.UIs
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject _winConditionObjectPanel;

        private void Awake()
        {
            if (_winConditionObjectPanel.activeSelf)
            {
                _winConditionObjectPanel.SetActive(false);
            }
        }


        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSucced;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSucced;

        }

        private void HandleOnMissionSucced()
        {
            if (!_winConditionObjectPanel.activeSelf)
            {
                _winConditionObjectPanel.SetActive(true);
            }
        }


    }

}
