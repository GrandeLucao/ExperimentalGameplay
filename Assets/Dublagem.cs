using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dublagem : MonoBehaviour
{
    public AudioClip myOneShotSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = myOneShotSound;
        audioSource.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Play();
        }
    }
}
