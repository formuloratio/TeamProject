using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : InteractionObject
{
    // 엘베랑 연결되는 스위치 번호
    public int switchIndex = 0;

    private void Awake()
    {
    }

    IEnumerator Start()
    {
        //인스턴스가 null이 아닐 때 넘어가도록
        yield return new WaitUntil(() => SwitchingManager.Instance != null);

        SwitchingManager.Instance.switchTagCompare[switchIndex] = 0;
        SwitchingManager.Instance.isSwitching = false;

        if (SwitchingManager.Instance.switchTagCompare == null)
        {
            SwitchingManager.Instance.switchTagCompare = new int[switchIndex + 1]; // 임시 크기 1로 초기화
        }

        GetObjectIndex();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //플레이어가 물일 때
        if (collider.CompareTag("PlayerWater"))
        {
            if (obstacleIndex == waterIndex) //같은 물이면
            {
                //스위치 동작
                isWater = true;

                SwitchingManager.Instance.isSwitching = true;
                SwitchingManager.Instance.switchTagCompare[switchIndex] = 1;
                Debug.Log("물 스위치 ON");
                Debug.Log(SwitchingManager.Instance.isSwitching);
            }
        }
        //플레이어가 불일 때
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == fireIndex) //같은 불이면
            {
                //스위치 동작
                isFire = true;

                SwitchingManager.Instance.isSwitching = true;
                SwitchingManager.Instance.switchTagCompare[switchIndex] = 1;
                Debug.Log("불 스위치 ON");
                Debug.Log(SwitchingManager.Instance.isSwitching);
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
                SwitchingManager.Instance.isSwitching = false;
                isWater = false;
                SwitchingManager.Instance.switchTagCompare[switchIndex] = 0;
                Debug.Log("물 스위치 OFF");
                Debug.Log(SwitchingManager.Instance.isSwitching);
            }
        }
        //플레이어가 불일 때
        else if (collider.CompareTag("PlayerFire"))
        {
            if (obstacleIndex == fireIndex) //같은 불이면
            {
                //스위치 꺼짐
                SwitchingManager.Instance.isSwitching = false;
                isFire = false;
                SwitchingManager.Instance.switchTagCompare[switchIndex] = 01;
                Debug.Log("불 스위치 OFF");
                Debug.Log(SwitchingManager.Instance.isSwitching);
            }
        }
    }
}
