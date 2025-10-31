﻿using Features.Entities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스위치 상호작용에 따라 움직이는 엘리베이터
public class Elevator : MonoBehaviour
{
    // 스위치 인덱스랑 같아야 함 0 ~ 9사이 지정
    public int elevatorIndex = 0;

    public float speed = 1.0f;

    public float maxLine = 5.4f;
    public float minLine = 0f;
    private AudioManager _audioManager;
    private bool isAudioPlayed = false;
    void Awake()
    {
        _audioManager = AudioManager.Instance;
    }

    private void Update()
    {
        if (SwitchingManager.Instance.isSwitching == true && SwitchingManager.Instance.switchTagCompare[elevatorIndex] == 1)
        {
            ElevatorMoveUp();
        }
        else if (SwitchingManager.Instance.isSwitching == false)
        {
            ElevatorMoveDown();
        }
    }

    private void ElevatorMoveUp()
    {
        Vector3 maxPos = this.gameObject.transform.position;
        if (this.gameObject.transform.position.y < maxLine)
        {
            maxPos.y += speed * Time.deltaTime;
        }
        else if (this.gameObject.transform.position.y >= maxLine)
        {
            maxPos.y = maxLine;
        }
        this.gameObject.transform.position = maxPos;
        if (!isAudioPlayed)
        {
            _audioManager.PlaySfx(_audioManager.elevatorMoveSfx);
            isAudioPlayed = true;
        }

    }

    private void ElevatorMoveDown()
    {
        Vector3 minPos = this.gameObject.transform.position;
        if (this.gameObject.transform.position.y > minLine)
        {
            minPos.y -= speed * Time.deltaTime;
        }
        else if (this.gameObject.transform.position.y >= minLine)
        {
            minPos.y = minLine;
        }
        this.gameObject.transform.position = minPos;
    }
  
}
