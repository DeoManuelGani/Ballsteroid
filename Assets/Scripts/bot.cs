using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot : MonoBehaviour
{
    public Transform ball;
    public Transform enemy;
    public float speed = 1f;
    private Vector2 destination;
    public float boundY = 2.25f;

    public void MoveToBall()
    {
        destination = new Vector2 (enemy.transform.position.x, ball.position.y);
        transform.position = Vector2.Lerp(enemy.transform.position, destination, speed * Time.deltaTime);
    }
        
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        MoveToBall();
    }
}
