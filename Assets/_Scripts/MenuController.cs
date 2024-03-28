using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _rocketsPanel;
    [SerializeField] private GameObject _musicOff;

    private void Start()
    {
        float music = PlayerPrefs.GetFloat("volume", 1);
        if (music == 1)
        {
            AudioListener.volume = 1;
            _musicOff.SetActive(false);
        }
        else
        {
            AudioListener.volume = 0;
            _musicOff.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void ChooseRocket()
    {
        _rocketsPanel.SetActive(true);
    }

    public void CloseChooseRocket()
    {
        _rocketsPanel.SetActive(false);
    }

    public void MusicButton()
    {
        if (!_musicOff.activeInHierarchy)
        {
            AudioListener.volume = 0;
            _musicOff.SetActive(true);
        }
        else
        {
            AudioListener.volume = 1;
            _musicOff.SetActive(false);
        }
        PlayerPrefs.SetFloat("volume", AudioListener.volume);
    }
}
