using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreLogic : MonoBehaviour
{
    Text str;
    int gameScore = 0;

    void Start()
    {
        str = GetComponent<Text>();
    }

    void Update()
    {
        printScore();
    }

    public void addToScoreVOID()
    {
        gameScore = gameScore + 1;
        printScore();
    }

    public void printScore()
    {
        str.text = " Score : " + gameScore;
    }
}
