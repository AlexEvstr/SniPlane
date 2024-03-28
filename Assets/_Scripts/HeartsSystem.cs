using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsSystem : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    [SerializeField] private GameObject _lose;

    private int _heartIndex;

    public void DestroyHeart()
    {
        hearts[_heartIndex].SetActive(false);
        

        if (_heartIndex == 2)
        {
            _lose.SetActive(true);
            Time.timeScale = 0;
        }

        _heartIndex++;
    }
}
