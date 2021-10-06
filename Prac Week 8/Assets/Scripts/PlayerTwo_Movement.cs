using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo_Movement : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        transform.Translate(Input.GetAxis("EnemyHorizontal") * speed * Time.deltaTime, 0, Input.GetAxis("EnemyVertical") * speed * Time.deltaTime);
    }
}
