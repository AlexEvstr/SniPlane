using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _bestScorePauseText;
    [SerializeField] private TMP_Text _bestScoreLoseText;

    public static int Score;
    private int _bestScore;

    private void Start()
    {
        _bestScore = PlayerPrefs.GetInt("bestScore", 0);
    }

    private void Update()
    {
        _scoreText.text = Score.ToString();
        if (Score >= _bestScore)
        {
            _bestScore = Score;
            PlayerPrefs.SetInt("bestScore", _bestScore);
        }
        _bestScorePauseText.text = $"Best: {_bestScore}";
        _bestScoreLoseText.text = $"Best: {_bestScore}";
    }

}
