using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static private ScoreKeeper instance;

    static public ScoreKeeper Instance()
    {
        return instance;
    }

    private void Awake()
    {
        instance = this;
    }

    public int pointsPerPickUp;
    private int score = 0;

    public int Score
    {
        get
        {
            return score;
        }
    }

    public void hit()
    {
        score += pointsPerPickUp;
    }
}
