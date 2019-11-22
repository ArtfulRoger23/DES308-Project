using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class LevelHandler : MonoBehaviour
{

    public int enemiesHit = 0;
    public int friendliesHit = 0;

    public int totalShots = 0;

    public int deaths = 0;

    public int levelRestarts = 0;

    public float timer = 0f;

    Scene thisScene;
    private void Start()
    {
        thisScene = SceneManager.GetActiveScene();
        AnalyticsEvent.LevelStart(thisScene.name,
                                      thisScene.buildIndex);
    }


    public void LevelFinished()
    {

        Analytics.CustomEvent("LevelCompleted " + SceneManager.GetActiveScene().name.ToString(), new Dictionary<string, object>
        {
            { "EnemiesShot", enemiesHit },
            { "FriendliesShot", friendliesHit  },
            { "TotalSHotsFired", totalShots },
            { "TotalDeaths", deaths },
            { "FinalTime", timer }
        });
    }

    public void LevelQuit()
    {
        Analytics.CustomEvent("LevelQuit " + SceneManager.GetActiveScene().name.ToString(), new Dictionary<string, object>
        {
            { "EnemiesShot", enemiesHit },
            { "FriendliesShot", friendliesHit  },
            { "TotalSHotsFired", totalShots },
            { "TotalDeaths", deaths },
            { "FinalTime", timer }
        });
    }

    
}
