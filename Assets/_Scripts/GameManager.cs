using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _pause;
    [SerializeField] private GameObject _lose;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void PausGame()
    {
        _pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ReturnToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
