using UnityEngine;

[RequireComponent(typeof(Light))]
public class Alarm : MonoBehaviour 
{
    AudioSource alarmSound;
    public GameObject ball;
    Vector3 initialPosition;

    void Start() 
    {
        initialPosition = new Vector3(-2.68f, 0.0f, 2.28f);
        alarmSound = GetComponent<AudioSource>();
    }

    // If ball enters light, play a sound and transport
    // it back to its original position
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == ball)
        {
            alarmSound.Play();        
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject == ball)
        {
            alarmSound.Stop();
            ball.transform.localPosition = initialPosition;
        }
    }

}
