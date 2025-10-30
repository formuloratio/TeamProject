using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitfall : Obstacle
{
    void Start()
    {
        GetObjectIndex();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == fireIndex)
            {
                //���� ����
                Destroy(collider.gameObject);
            }
        }
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == waterIndex)
            {
                //���� ����
                Destroy(collider.gameObject);
            }
        }
    }
}
