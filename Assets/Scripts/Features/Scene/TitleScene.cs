using System;
using Core;
using UnityEngine;
using UnityEngine.UI;

namespace Features.Scene
{
    public class TitleScene : MonoBehaviour
    {
        private GameManager _gameManager;
        private SceneTransitionManager _sceneTransitionManager;
        [SerializeField] private string nextSceneName = "GamePlayScene";

        void Awake()
        {
            _gameManager = GameManager.Instance;
            _sceneTransitionManager = SceneTransitionManager.Instance;
        }


        public void OnStartClicked()
        {
            _gameManager.OnGameStarted();
            _sceneTransitionManager.FadeAndLoadScene(nextSceneName);
        }

        public void OnQuitClicked()
        {
            Application.Quit();
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
}