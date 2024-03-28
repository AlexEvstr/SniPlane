using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordersDetector : MonoBehaviour
{
    [SerializeField] private HeartsSystem _heartSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Missle"))
        {
            Destroy(collision.gameObject);
            _heartSystem.DestroyHeart();
        }
    }
}
