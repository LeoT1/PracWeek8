using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

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
