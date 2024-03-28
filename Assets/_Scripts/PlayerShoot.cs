using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _circlePrefab;

    [SerializeField] private GameObject _tapToShotTutorial;

    public void ShootButton()
    {
        _tapToShotTutorial.SetActive(false);
        GameObject circlePrefab = Instantiate(_circlePrefab);
        circlePrefab.transform.position = _player.transform.position;
        circlePrefab.transform.rotation = _player.transform.rotation;
    }
}
