using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzleCheck : MonoBehaviour
{
    public List<LightPuzzle> puzzleList = new List<LightPuzzle>();
    public List<bool> puzzleCheck = new List<bool>();
    private AudioSource audioSource;
    public AudioClip audioClip;
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
    }

    public void CheckSuccess()
    {
        int index = 0;
        for (int i = 0; i < puzzleList.Count; i++)
        {
            if (puzzleList[i].isActive != puzzleCheck[i]) { return; }
            index++;
        }
        //Puzzle terminado
        audioSource.clip = audioClip;
        audioSource.volume = 0.3f;
        audioSource.PlayOneShot(audioSource.clip);
    }
}
