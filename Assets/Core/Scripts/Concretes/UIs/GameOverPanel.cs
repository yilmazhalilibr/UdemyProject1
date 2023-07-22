using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;


namespace UdemyProject1.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClick()
        {
            GameManager.Instance.LoadLevelScene();
        }
        public void NoClick()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}

