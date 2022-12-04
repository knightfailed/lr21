using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public bool FirstLaneBlueCar, FirstLaneOrangeCar;
    public bool BlueCar;

    public Vector2 Xpos;

    void start()
    {
           
    }

    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            LeftButtonPressed();
        }
        if (Input.GetKeyDown("right"))
        {
            RightButtonPressed();
        }
        if (BlueCar)
        {
            if (FirstLaneBlueCar)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(-Xpos.y, transform.position.y, 0), .1f);
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(-Xpos.x, transform.position.y, 0), .1f);
            } 
        }
        else
        {
            if (FirstLaneOrangeCar)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(-Xpos.y, transform.position.y, 0), .1f);
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(-Xpos.x, transform.position.y, 0), .1f);
            } 
        }
    }

    public void  LeftButtonPressed()
    {
        if (FirstLaneBlueCar) { FirstLaneBlueCar = false; } else {FirstLaneBlueCar = true; }
    }

    public void  RightButtonPressed()
    {
        if (FirstLaneOrangeCar) { FirstLaneOrangeCar = false; } else {FirstLaneOrangeCar = true; }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            FindObjectOfType<GameController>().AddScore();
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Cube")
        {
            FindObjectOfType<GameController>().GameOver();
            Debug.Log("playerGO");
        }
    }
}
