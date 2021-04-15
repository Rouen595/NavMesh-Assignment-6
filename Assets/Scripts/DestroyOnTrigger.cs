using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public string tag = "Player";

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == tag)
        {
            Score.CurrentScore += 10;
            Destroy(gameObject);

        }
    }
}
