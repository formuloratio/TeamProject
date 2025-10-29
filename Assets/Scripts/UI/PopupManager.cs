using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Core;

public class PopupManager : MonoBehaviour
{
    [Header("Popup UI")]
    public GameObject popupCanvas; // PopupCanvas 연결

    void Start()
    {
        // 시작할 때 팝업 숨기기
        if (popupCanvas != null)
            popupCanvas.SetActive(false);
    }

    void Update()
    {
        // ESC 키로 팝업 열기 / 닫기
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePopup();
        }
    }

    public void TogglePopup()
    {
        if (popupCanvas == null) return;

        bool show = !popupCanvas.activeSelf;
        popupCanvas.SetActive(show);

        if (show)
            GameManager.Instance.OnGamePaused();
        else
            GameManager.Instance.OnGameStarted();
    }

    //게임 새로 재시작 
    public void OnRestartButton()
    {
        Time.timeScale = 1f;
        GameManager.Instance.OnGameStarted();
        SceneTransitionManager.Instance.FadeAndLoadScene("GamePlayScene");

    }
    //게임 이어서 시작 
    public void OnResumeButton()
    {
        if (popupCanvas != null)
            popupCanvas.SetActive(false); // 팝업 사라지게

        Time.timeScale = 1f; // 시간 재개
        GameManager.Instance.OnGameStarted();
    }

    //타이틀로 이동
    public void OnTitleButton()
    {
        Time.timeScale = 1f;
        GameManager.Instance.OnGamePaused();
        SceneTransitionManager.Instance.FadeAndLoadScene("TitleScene");
    }

    //게임 종료
    public void OnQuitButton()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

    }
}



