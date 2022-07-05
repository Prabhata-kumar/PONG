
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scoreToReach;
    public Ball ball;

    public PlayerPadal playerPaddle;
    public int playerScore { get; private set; }
    public Text playerScoreText;

    public ComputerPadal computerPaddle;
    public int computerScore { get; private set; }
    public Text computerScoreText;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        CheckScore();
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
         ball.ResetPosition();
    }

    public void PlayerScores()
    {
      
        SetPlayerScore(playerScore + 1);
        StartRound();
       
    }

    public void ComputerScores()
    {

        SetComputerScore(computerScore + 1);
        StartRound();

    }
    private void SetPlayerScore(int score)
    {
      
        playerScore = score;
        playerScoreText.text = score.ToString();
      
    }

    private void SetComputerScore(int score)
    {
       
        computerScore = score;
        computerScoreText.text = score.ToString();
       
    }

    private void CheckScore()
    {
        if (playerScore==scoreToReach || computerScore==scoreToReach)
        {
            SceneManager.LoadScene(2);
          
        }
    }
}
