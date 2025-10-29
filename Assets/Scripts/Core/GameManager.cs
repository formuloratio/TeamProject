using UnityEngine;
using Utils;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

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
        }

        public void OnGameStarted()
        {
            _state = GameState.Playing;
        }

        public void OnGamePaused()
        {
            _state = GameState.Paused;
        }

        public void OnGameOver()
        {
            _state = GameState.GameOver;
        }

        public void OnGameClear()
        {
            _state = GameState.GameClear;
        }
    }
}
