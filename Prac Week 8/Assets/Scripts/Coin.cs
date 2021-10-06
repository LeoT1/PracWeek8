using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreKeeper.Instance().hit();
        }
        if (other.CompareTag("Player2"))
        {
            Destroy(gameObject);
            scorekeeper.HitTwo();
        }
    }
}
