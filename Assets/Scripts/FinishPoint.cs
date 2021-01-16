using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D pointCollider)
    {
        if (pointCollider.TryGetComponent<Player>(out Player player))
        {
            Destroy(pointCollider.gameObject);
        }
    }
}