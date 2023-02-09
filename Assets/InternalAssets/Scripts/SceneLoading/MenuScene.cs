namespace InternalAssets.Scripts
{
    public class MenuScene : ScenePresenter
    {
        private LevelLoader _loader;
        
        public MenuScene(LevelLoader loader) : base(loader)
        {
            _loader = loader;
        }
    }
}