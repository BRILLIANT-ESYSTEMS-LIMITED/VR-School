using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
