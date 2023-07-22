using UdemyProject1.Controllers;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player != null || !player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

