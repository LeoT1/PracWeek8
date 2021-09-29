using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    public float speed = 2f;
    public float left = -3f;
    public float right = 3f;

    private float direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.x <= left)
        {
            direction = 1;
        }
      if (transform.position.x >= right)
        {
            direction = -1;
        }
        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
    }
}
