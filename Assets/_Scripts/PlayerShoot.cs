using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _circlePrefab;

    public void ShootButton()
    {
        GameObject circlePrefab = Instantiate(_circlePrefab);
        circlePrefab.transform.position = _player.transform.position;
        circlePrefab.transform.rotation = _player.transform.rotation;
    }
}
