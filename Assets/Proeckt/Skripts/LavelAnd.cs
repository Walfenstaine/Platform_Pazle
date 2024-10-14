using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class LavelAnd : MonoBehaviour {
	public string level;
    public static LavelAnd rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    public void Reload()
    {
        if (YandexGame.savesData.lives > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            YandexGame.savesData.lives -= 1;
            YandexGame.SaveProgress();
        }
        else 
        {
            YandexGame.savesData.coins = 0;
            YandexGame.savesData.scene = "Scene1";
            YandexGame.savesData.lives = 3;
            YandexGame.SaveProgress();
            SceneManager.LoadScene("Scene1");
        }
    }
    public void Reclame()
    {
        YandexGame.SaveProgress();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Next()
    {
        YandexGame.NewLeaderboardScores("LEADER22", YandexGame.savesData.coins);
        YandexGame.savesData.scene = level;
        YandexGame.SaveProgress();
        SceneManager.LoadScene(level);
    }
}
