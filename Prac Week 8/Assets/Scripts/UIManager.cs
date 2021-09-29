 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Canvas canvas;
    private int score;

    ScoreKeeper scorekeeper;

    // Start is called before the first frame update
    void Start()
    {
        scorekeeper = GameObject.Find("Scorekeeper").GetComponent<ScoreKeeper>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        score = scorekeeper.Score;
        canvas.gameObject.transform.GetChild(0).GetComponent<Text>().text += score;
    }

    // Update is called once per frame
    void Update()
    {
        if (score < scorekeeper.Score)
        {
            score = scorekeeper.Score;
            canvas.gameObject.transform.GetChild(0).GetComponent<Text>().text = "Score: "+ score.ToString();
        }
    }
}
