using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;

    private int _heartIndex;

    public void DestroyHeart()
    {
        hearts[_heartIndex].SetActive(false);
        _heartIndex++;

        if (_heartIndex == 2)
        {
            Debug.Log("Game over");
        }
    }
}
