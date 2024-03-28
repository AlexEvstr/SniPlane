using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleSkin : MonoBehaviour
{
    [SerializeField] private Sprite[] _missles;

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = _missles[PlayerPrefs.GetInt("rocketIndex", 0)];
    }
}
