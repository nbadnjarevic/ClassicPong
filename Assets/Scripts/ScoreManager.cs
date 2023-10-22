using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        if(playerOneScore == 10)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public void playerTwoGoal()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
        if (playerTwoScore == 10)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
