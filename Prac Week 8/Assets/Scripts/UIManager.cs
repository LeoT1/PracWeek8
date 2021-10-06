 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Canvas canvas;
    private int score;
    private int scoreTwo;

    void Update()
{
        score = ScoreKeeper.Instance().Score;
        scoreTwo = ScoreKeeper.Instance().ScoreTwo;
        canvas.gameObject.transform.GetChild(0).GetComponent<Text>().text = "Player 1 Score: " + score.ToString();
        canvas.gameObject.transform.GetChild(1).GetComponent<Text>().text = "Player 2 Score: " + scoreTwo.ToString();
    }
}
