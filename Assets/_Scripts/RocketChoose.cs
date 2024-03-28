using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketChoose : MonoBehaviour
{
    [SerializeField] private GameObject _greenCircle;

    private void Start()
    {
        string index = PlayerPrefs.GetInt("rocketIndex", 0).ToString();
        if (index == gameObject.name)
        {
            ChooseThisRocket();
        }
    }

    public void ChooseThisRocket()
    {
        _greenCircle.transform.SetParent(transform, false);
        PlayerPrefs.SetInt("rocketIndex", int.Parse(gameObject.name));
    }
}
