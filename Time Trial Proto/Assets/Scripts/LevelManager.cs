using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public enum LevelPlayState { InProgress, Won, Quit }

    private Scene thisScene;
    private LevelPlayState state = LevelPlayState.InProgress;
    int deaths = 0;
    int score = 0;




    void Start()
    {
        thisScene = SceneManager.GetActiveScene();
        AnalyticsEvent.LevelStart(thisScene.name,
                                      thisScene.buildIndex);
    }

    public void SetLevelPlayState(LevelPlayState newState)
    {
        this.state = newState;
    }

    public void IncrementDeaths()
    {
        deaths++;

    }
    public void IncreaseScore(int points)
    {
        score+= points;
    }
        void OnDestroy()
    {
        Dictionary<string, object> customParams = new Dictionary<string, object>();
        customParams.Add("deaths", deaths);
        customParams.Add("points", score);

        switch (this.state)
        {
            case LevelPlayState.Won:
                AnalyticsEvent.LevelComplete(thisScene.name,
                                                 thisScene.buildIndex,
                                                 customParams);

                break;
            case LevelPlayState.InProgress:


            case LevelPlayState.Quit:
            default:
                AnalyticsEvent.LevelQuit(thisScene.name,
                                             thisScene.buildIndex,
                                             customParams);
                break;
        }



    }
}