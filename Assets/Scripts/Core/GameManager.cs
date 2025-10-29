using UnityEngine;
using Utils;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        private GameState _state;
        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _state = GameState.Run;
        }

        public void OnGameStarted()
        {
            _state = GameState.Run;
        }
    }
}
