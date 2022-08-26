using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(-2, 0) == 0 ? -1 : -1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
