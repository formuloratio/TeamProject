using Features.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Wall : InteractionObject
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //플레이어가 물일 때
        if (collision.gameObject.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == fireIndex)
            {
                //불 벽 삭제
                Destroy(this.gameObject);
            }
        }
        //플레이어가 불일 때
        else if (collision.gameObject.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == waterIndex)
            {
                //물 벽 삭제
                Destroy(this.gameObject);
            }
        }

    }
}
