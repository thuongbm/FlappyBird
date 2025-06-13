using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public Text scoreText;
    public GameObject gameOver;

    [ContextMenu("Increase Score")]
    public void IncreaseScore()
    {
        addScore(1);
    }
    public void addScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }
}
