using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            ScoreCounter.Score++;
            Destroy(collision.gameObject);
            GameObject newTarget = Instantiate(_target);
            _target.transform.position = new Vector2(Random.Range(-2, 2), Random.Range(1, 4));
            Destroy(gameObject);
        }
    }
}
