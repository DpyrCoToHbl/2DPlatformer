using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private AudioSource _coinSound;

    public bool IsAllCoinsCollected { get; private set; }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent<Player>(out Player player))
        {
            _coinSound.Play();
            Destroy(gameObject, 0.3f);
        }

    }

}
