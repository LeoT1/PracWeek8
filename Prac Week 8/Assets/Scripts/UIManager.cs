 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Canvas canvas;
    private int score;

    void Update()
{
        score = ScoreKeeper.Instance().Score;
        canvas.gameObject.transform.GetChild(0).GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
