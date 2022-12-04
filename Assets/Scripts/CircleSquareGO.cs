using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSquareGO : MonoBehaviour
{
    int speed;
    Rigidbody2D rgbd;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        rgbd = GetComponent<Rigidbody2D>();
        rgbd.velocity = new Vector2(0, -speed);
    }

    
}
