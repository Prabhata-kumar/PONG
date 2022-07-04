
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scoreToReach = 1;
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
      //
      //ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        CheckScore();
        SetPlayerScore(playerScore + 1);
        StartRound();
        CheckScore();
        print("check 1");

    }

    public void ComputerScores()
    {
        CheckScore();
        SetComputerScore(computerScore + 1);
        StartRound();
        CheckScore();
        print("check 2");
    }

    private void SetPlayerScore(int score)
    {
        CheckScore();
        playerScore = score;
        playerScoreText.text = score.ToString();
        CheckScore();
        print("check 3");

    }

    private void SetComputerScore(int score)
    {
        CheckScore();
        computerScore = score;
        computerScoreText.text = score.ToString();
        CheckScore();
        print("check 4");
    }

    private void CheckScore()
    {
        if (playerScore==scoreToReach || computerScore==scoreToReach)
        {
            SceneManager.LoadScene(2);
            print("checking update");
        }
    }
}
