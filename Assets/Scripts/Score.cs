using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int CurrentScore;

    public Text scoreText;
    public GameManager gameManager;

    void Start()
    {
        CurrentScore = 0;

    }
    void Update()
    {
        if (CurrentScore < 0)
        {
            CurrentScore = 0;
        }
        scoreText.text = "Score: " + CurrentScore.ToString();

        if (CurrentScore >= 60)
        {
            Debug.Log("YOU WIN!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
