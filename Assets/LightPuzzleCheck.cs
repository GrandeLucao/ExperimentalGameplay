using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzleCheck : MonoBehaviour
{
    public List<LightPuzzle> puzzleList = new List<LightPuzzle>();
    public List<bool> puzzleCheck = new List<bool>();
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CheckSuccess();
    }

    public void CheckSuccess()
    {
        for (int i = 0; i < puzzleList.Count; i++)
        {
            if (puzzleList[i].isActive != puzzleCheck[i]) { return; }
        }
        //Puzzle terminado
        this.gameObject.SetActive(false);
    }
}
