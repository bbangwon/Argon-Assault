using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Start";
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = score.ToString();
    }
}
