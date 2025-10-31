namespace Features.Scene
{
    public class GameScene
    {
        private AudioManager _audioManager;

        void Awake()
        {
            _audioManager = AudioManager.Instance;
        }

        void Start()
        {
            _audioManager.PlayBgm(_audioManager.gameplayBgm);
        }
    }
}