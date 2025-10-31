using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Core;
using Utils;
using TMPro;

public class TimerUI : MonoBehaviour
{
    //inspect에서 연결 가능하게
    [SerializeField] private TMP_Text timerText;


    private void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.CurrentState == GameState.Playing)//게임 상태가 Playing일 때만 타이머를 갱신.
        {
            timerText.text = GameManager.Instance.CurrentTime.ToString("F2"); //CurrentTime을 불러와 UI에 표시. "F2": 소수점 2자리까지 표시 
        }
    }
}
