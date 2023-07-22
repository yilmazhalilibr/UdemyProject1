using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controllers;
using UnityEngine;


namespace UdemyProject1.Movements
{
    public class Mover
    {
        PlayerController _PlayerController;
        Rigidbody _rigidbody;

        public Mover(PlayerController PlayerController)
        {
            _PlayerController = PlayerController;
            _rigidbody = _PlayerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _PlayerController.Force);
        }



    }
}

