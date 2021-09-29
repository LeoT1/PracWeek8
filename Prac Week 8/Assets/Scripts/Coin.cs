using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ScoreKeeper scorekeeper;

    public void Start()
    {
        scorekeeper = GameObject.Find("Scorekeeper").GetComponent<ScoreKeeper>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            scorekeeper.AddPoints();
        }
    }
}
