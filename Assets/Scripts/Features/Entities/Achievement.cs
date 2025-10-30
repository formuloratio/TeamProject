using Data.ScriptableObjects;
using Utils;

namespace Features.Entities
{
    public class Achievement
    {
        public AchievementData AchievementData;
        public int CurrentCount;
        public bool IsUnlocked { get; private set; }

        public Achievement(AchievementData data)
        {
            AchievementData = data;
            CurrentCount = 0;
            IsUnlocked = false;
        }

        public void AddProgress(int amount = 0)
        {
            if (IsUnlocked) return;

            CurrentCount += amount;
            CheckUnlock();
        }

        public void SetProgress(int value)
        {
            if (IsUnlocked) return;

            CurrentCount = value;
            CheckUnlock();
        }

        private void CheckUnlock()
        {
            bool achieved = AchievementData.clearType switch
            {
                AchievementClearType.Equals => CurrentCount == AchievementData.targetCount,
                AchievementClearType.Under => CurrentCount <= AchievementData.targetCount,
                AchievementClearType.Over => CurrentCount >= AchievementData.targetCount,
                _ => false
            };

            if (achieved)
            {
                IsUnlocked = true;
            }
        }

    }
}