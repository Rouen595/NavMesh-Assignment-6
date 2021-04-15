// LOW MAN
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Text creditsName;
    public Text creditsLives;

    void Start()
    {
        creditsName.text = "Congratulations, " + Name.username + ", you won!";
        creditsLives.text = "Lives: " + ChooseNumLives.numLives;
    }

    public void RestartGame()
    {
        Score.CurrentScore = 0;
        ChooseNumLives.numLives = 5;
        Name.username = "Lowman";
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("QUIT");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }



    /*
    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    */
}
