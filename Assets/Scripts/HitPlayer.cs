using UnityEngine;
using UnityEngine.SceneManagement;

public class HitPlayer : MonoBehaviour
{
    public string tag = "Player";

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tag)
        {
            ChooseNumLives.numLives--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Destroy(gameObject);

        }
    }
}
