using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    public int pointsPerPickUp;
    public int score;

    public void AddPoints()
    {
        score += pointsPerPickUp; 
    }
}
