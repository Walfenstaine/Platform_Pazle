
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public int coins = 0;
        public int lives = 3;
        public bool soundOn;
        public string scene = "Scene1";

        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            
        }
    }
}
