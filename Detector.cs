using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public Transform player;
    public Transform enemy;
    public float detectionRadius = 5f;
    public AudioClip detectionSound;
    public float minDistanceToPlaySound = 2f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        if (Vector3.Distance(player.position, enemy.position) < detectionRadius)
        {
            if (Vector3.Distance(player.position, enemy.position) < minDistanceToPlaySound)
            {
                PlayDetectionSound();
            }
        }
    }

    void PlayDetectionSound()
    {
        if (detectionSound != null && !audioSource.isPlaying)
        {
            audioSource.PlayOneShot(detectionSound);
        }
    }
}
