using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private int score = 0;
    private int lastOutputScore = 0;

    private TMPro.TextMeshPro _text;

    // Start is called before the first frame update
    void Start()
    { 
        _text = GetComponent<TextMeshPro>();
        _text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (lastOutputScore != score) {
            lastOutputScore = score;
            _text.text = score.ToString();
        }
    }

    public void ScoredAction(int value)
    {
        score += value;
    }

    public void ResetAction()
    {
        score = 0;
    }
}
