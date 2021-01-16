using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private LayerMask _ground;

    private void OnTriggerEnter2D(Collider2D ground)
    {
        if (_playerMovement.gameObject.layer == _ground)
        {
            _playerMovement.isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D ground)
    {
        _playerMovement.isGrounded = false;
    }
}
