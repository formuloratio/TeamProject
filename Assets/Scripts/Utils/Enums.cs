using UnityEngine;

namespace Utils
{
        public enum PlayerType
        {
            Fire,Water

        }

        public enum GameState
        {
            Title, Playing, Paused, GameOver, GameClear
        }

        public enum AchievementType
        {
            StageClear, AchievedScore , ClearTime, DeathCount
        }

        public enum AchievementClearType
        {
            Equals, Under, Over
        }
}
