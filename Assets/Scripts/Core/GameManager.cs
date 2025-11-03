using UnityEngine;
using Utils;
using Core;
using UnityEngine.SceneManagement;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        private AudioManager _audioManager;
        private AchievementManager _achievementManager;

        private GameState _state;

        public GameState CurrentState => _state;

        private int _currentStageNum = 0;
        public int CurrentStageNum => _currentStageNum;
        private SceneTransitionManager _sceneTransitionManager;


        [Header("Timer Settings")]
        public float levelTimeLimit = 60f;  // 제한시간 60초
        private float currentTime;
        public float CurrentTime => currentTime; // 다른 스크립트에서 확인 가능 읽기전용 프로퍼티

        public bool isPlaying => _state == GameState.Playing; //현재 게임 진행중인지

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _state = GameState.Title;

        }
        private void Start()
        {
            _audioManager = AudioManager.Instance;
            _sceneTransitionManager = SceneTransitionManager.Instance;
            _achievementManager = AchievementManager.Instance;
            OnGameStarted(); // 게임 시작 시 자동으로 타이머 시작
        }

        private void Update()
        {
            if (_state == GameState.Playing)
            {
                currentTime -= Time.deltaTime;
                if (currentTime < 0f)
                    currentTime = 0f;

                // Debug: 시간 소수점 둘째자리까지 출력
                // Debug.Log("Time Left: " + currentTime.ToString("F2"));

                // 제한시간 초과 시 실패
                if (currentTime <= 0f)
                {
                    OnGameOver();
                    GameOverManager.Instance.ShowGameOver();
                }
            }
        }

        #region Game State Methods
        public void OnGameStarted()
        {
            _state = GameState.Playing;
            currentTime = levelTimeLimit; // 타이머 초기화
            Time.timeScale = 1f;
            _audioManager.PlayBgm(_audioManager.gameplayBgm);
        }

        public void OnGamePaused()
        {
            _state = GameState.Paused;
            _audioManager.StopBGM();
        }

        public void OnGameOver()
        {
            _state = GameState.GameOver;
            _audioManager.PlaySfx(_audioManager.gameOver);
            _achievementManager.CheckAndSetProgress(ProgressType.Add, AchievementType.DeathCount);
        }

        public void OnGameClear(float timeTaken)
        {
            _state = GameState.GameClear;
            _currentStageNum++;
            _achievementManager.CheckAndSetProgress(ProgressType.Set, AchievementType.StageClear, _currentStageNum);
            _achievementManager.CheckAndSetProgress(ProgressType.Set, AchievementType.GetRank, (int)timeTaken);
            _audioManager.PlaySfx(_audioManager.clearSfx);
        }
        public void PauseGame()
        {
            _state = GameState.Paused;
            Time.timeScale = 0f;
            _audioManager.PauseBGM();
        }

        public void ResumeGame()
        {
            _state = GameState.Playing;
            Time.timeScale = 1f;
            _audioManager.ResumeBGM();
        }

        public void ResetCurrentStage()
        {
            _currentStageNum = 0;
        }

        #endregion
        public void GoNextStage()
        {
            if (!IsNextStageExist()) return;
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {

                if (Time.timeScale == 0f)
                {
                    Time.timeScale = 1f;
                }
                _sceneTransitionManager.FadeAndLoadSceneByIndex(nextSceneIndex);
            }
        }

        public bool IsNextStageExist()
        {
            return _currentStageNum < GameStateConstans.MaxStageNum;
        }
    }
}