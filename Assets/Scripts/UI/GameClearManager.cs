using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Core;

public class GameClearManager : MonoBehaviour
{
    public static GameClearManager Instance { get; private set; }

    [SerializeField] private GameObject clearPanel;
    [SerializeField] private Button retryButton;
    [SerializeField] private Button titleButton;
    [SerializeField] private Button nextStageButton;
    public bool FireOnLeftDoor { get; set; } = false;
    public bool WaterOnRightDoor { get; set; } = false;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        if (clearPanel != null)
            clearPanel.SetActive(false);

    }
    private void Start()
    {
        retryButton.onClick.AddListener(RestartStage);
        titleButton.onClick.AddListener(GoToTitle);
        nextStageButton.onClick.AddListener(GoToNextStage);
    }

    public void ShowClearPanel()
    {
        clearPanel.SetActive(true);
        GameManager.Instance.OnGameClear();
        Time.timeScale = 0f;
    }

    private void RestartStage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void GoToTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScene");
    }

    private void GoToNextStage()
    {

    }
}
