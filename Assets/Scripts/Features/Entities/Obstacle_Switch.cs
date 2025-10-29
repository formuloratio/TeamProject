using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Switch : InteractionObject
{
    // 엘베랑 연결되는 스위치 번호
    public int switchIndex = 0;

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
        //플레이어가 물일 때
        if (collider.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == waterIndex) //같은 물이면
            {
                //스위치 동작
                isSwitching = true;
                isWater = true;
                switchIndexArray[switchIndex] = 1;
                Debug.Log("물 스위치 ON");
            }
        }
        //플레이어가 불일 때
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == fireIndex) //같은 불이면
            {
                //스위치 동작
                isSwitching = true;
                isFire = true;
                switchIndexArray[switchIndex] = 1;
                Debug.Log("불 스위치 ON");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        //플레이어가 물일 때
        if (collider.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == waterIndex) //같은 물이면
            {
                //스위치 꺼짐
                isSwitching = false;
                isWater = false;
                Debug.Log("물 스위치 OFF");
            }
        }
        //플레이어가 불일 때
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == fireIndex) //같은 불이면
            {
                //스위치 꺼짐
                isSwitching = false;
                isFire = false;
                Debug.Log("불 스위치 OFF");
            }
        }
    }
}
