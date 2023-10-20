using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int playerOneScore = 0;
    private int playerTwoScore = 0;

    public TMP_Text playerOneScoreText;
    public TMP_Text playerTwoScoreText;

    public void playerOneGoal()
    {
        playerOneScore++;
        playerOneScoreText.text = playerOneScore.ToString();
    }

    public void playerTwoGoal()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
    }
}
