using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Pitfall : InteractionObject
{
    public override void Interact()
    {

    }

    void Start()
    {
        Transform parentTransform = this.transform;
        for (int i = 0; i < parentTransform.childCount; i++)
        {
            Transform childTransform = parentTransform.GetChild(i);

            if (childTransform.gameObject.activeSelf)
            {
                obstacleIndex = i;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == fireIndex)
            {
                //게임 오버
                Destroy(collider.gameObject);
            }
        }
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == waterIndex)
            {
                //게임 오버
                Destroy(collider.gameObject);
            }
        }
    }
}
