using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal : MonoBehaviour 
{
    public GameObject ball;
    public Button menuButton;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == ball)
        {
            audioSource.Play();
            menuButton.gameObject.SetActive(true);
        }
    }

}
