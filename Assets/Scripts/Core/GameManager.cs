using UnityEngine;
using Utils;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        private AudioManager _audioManager;

        private GameState _state;

        public GameState CurrentState => _state;

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
            _audioManager = AudioManager.Instance;
        }

        public void OnGameStarted()
        {
            _state = GameState.Playing;
            _audioManager.StopBGM();
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
        }

        public void OnGameClear()
        {
            _state = GameState.GameClear;
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
    }
}
