using UnityEngine;

public class Oscillator : MonoBehaviour
{

    public float amplitude = 0.5f;
    public float period = 1.5f;
    public Vector3 direction = Vector3.up;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = startPosition + direction * amplitude * Mathf.Sin(2.0f * Mathf.PI * Time.time / period);
        transform.position = pos;
    }
}
