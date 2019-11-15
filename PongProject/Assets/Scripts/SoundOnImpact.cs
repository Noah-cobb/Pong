using UnityEngine;
using System.Collections;

public class SoundOnImpact : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       // if (collision.gameObject.tag == "Goal")
        {
           
            audioSource.clip = Scored;
            audioSource.Play();
        }
    }
}