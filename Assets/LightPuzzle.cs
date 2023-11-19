using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPuzzle : MonoBehaviour
{
    public Color newColor;
    private SpriteRenderer rend;
    private Color ogColor;
    public bool isActive = true;
    public List<LightPuzzle> neighbours = new List<LightPuzzle>();
    public LightPuzzleCheck check;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        ogColor = rend.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive) { rend.color = newColor; }
        else { rend.color = ogColor; }    
    }

    public void ToggleNeighbours()
    {
        Toggle();
        for(int i = 0; i < neighbours.Count; i++)
        {
            neighbours[i].Toggle();
        }
        check.CheckSuccess();
    }
    public void Toggle()
    {
        isActive = !isActive;
    }
}
