using System.Collections.Generic;
using System.Linq;
using Data.ScriptableObjects;
using Features.Entities;
using UnityEngine;

namespace Core
{
    public class AchievementManager  : MonoBehaviour
    {
        public static AchievementManager  Instance { get; private set; }
        private DataService _dataService;
        private const string DataPrefix = "Achievement";
        private const string ResourcesPath = "ScriptableObjects/Achievements";
        private Dictionary<string, Achievement> _achievements = new Dictionary<string, Achievement>();


        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);

            _dataService = new DataService(DataPrefix);
            InitializeAchievements();
            LoadProgress();
        }

        #region public methods

        /// <summary>
        /// 특정 업적의 진행도를 증가시키고 달성 여부를 확인합니다.
        /// </summary>
        /// <param name="id">업적 ID</param>
        /// <param name="amount">증가시킬 진행도 (기본값: 0)</param>
        public void AddProgress(string id, int amount = 0)
        {
            if (!_achievements.ContainsKey(id))
            {
                return;
            }

            var achievement = _achievements[id];
            bool wasUnlocked = achievement.IsUnlocked;

            achievement.AddProgress(amount);

            if (!wasUnlocked && achievement.IsUnlocked)
            {
                Debug.Log($"[AchievementManager] achievement Defeated: {achievement.AchievementData.displayName}");
            }

            SaveProgress();
        }

        /// <summary>
        /// ID로 특정 업적 정보를 조회합니다.
        /// </summary>
        /// <param name="id">조회할 업적 ID</param>
        /// <returns>해당 업적 객체. 존재하지 않으면 null</returns>
        public Achievement GetAchievement(string id)
        {
            return _achievements.ContainsKey(id) ? _achievements[id] : null;
        }

        /// <summary>
        /// 등록된 모든 업적 목록을 반환합니다.
        /// </summary>
        /// <returns>전체 업적 리스트</returns>
        public List<Achievement> GetAllAchievements()
        {
            return _achievements.Values.ToList();
        }

        #endregion


        private void InitializeAchievements()
        {
            AchievementData[] loadedData = Resources.LoadAll<AchievementData>(ResourcesPath);
            foreach (var data in loadedData)
            {
                if (string.IsNullOrEmpty(data.id))
                {
                    continue;
                }

                if (_achievements.ContainsKey(data.id))
                {
                    continue;
                }
                var achievement = new Achievement(data);
                _achievements[data.id] = achievement;

            }
        }

        private void SaveProgress()
        {
            var saveData = new AchievementSaveData
            {
                progressList = new List<AchievementProgress>()
            };

            foreach (var achievement in _achievements.Values)
            {
                saveData.progressList.Add(new AchievementProgress
                {
                    id = achievement.AchievementData.id,
                    currentCount = achievement.CurrentCount,
                    isUnlocked = achievement.IsUnlocked
                });
            }

            _dataService.Save(saveData, DataPrefix);
        }
        private void LoadProgress()
        {
            var saveData = _dataService.Load<AchievementSaveData>(DataPrefix);

            if (saveData?.progressList == null || saveData.progressList.Count == 0)
            {
                return;
            }

            foreach (var progress in saveData.progressList)
            {
                if (_achievements.ContainsKey(progress.id))
                {
                    _achievements[progress.id].SetProgress(progress.currentCount);

                    if (progress.isUnlocked && !_achievements[progress.id].IsUnlocked)
                    {
                        _achievements[progress.id].SetProgress(_achievements[progress.id].AchievementData.targetCount);
                    }
                }
            }
        }



        [System.Serializable]
        private class AchievementSaveData
        {
            public List<AchievementProgress> progressList;
        }

        [System.Serializable]
        private class AchievementProgress
        {
            public string id;
            public int currentCount;
            public bool isUnlocked;
        }
    }
}
