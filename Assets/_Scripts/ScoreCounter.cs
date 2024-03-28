using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;


    public static int Score;
    private int _bestScore;

    private void Update()
    {
        _scoreText.text = Score.ToString();
        if (Score >= _bestScore)
        {
            _bestScore = Score;
        }
    }

}
