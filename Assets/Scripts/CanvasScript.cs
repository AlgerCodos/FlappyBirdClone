using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CanvasScript : MonoBehaviour
{
    public PlayerController player;
    public Button restartButton;
    public Button menuButton;
    public TextMeshProUGUI scoreText;
    private float elapsedTime = 0f;
    private int score = 0;
    private int highScore;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        //calculating time 
        elapsedTime += Time.deltaTime * 10; 
        //score calculating
        if(elapsedTime >= 10f && !player.isDead)
        {
            score += 1;
            elapsedTime = 0f;
            scoreText.text = "Score: " + score;
        }

        if(player.isDead == true)
        {
            restartButton.gameObject.SetActive(true);
            menuButton.gameObject.SetActive(true);
        }

        //new high score
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            UpdateHighScoreUI();
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void UpdateHighScoreUI()
    {
        highScoreText.text = "High score: " + highScore;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
