using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    
    public GameObject gameOver;

    private int _score;
    
    public static GameController Instance;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }


    public void AddScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
}
