using UnityEngine;
using Mkey;
using UnityEngine.SocialPlatforms.Impl;

public class ReadScoreLoader : MonoBehaviour
{
    public ScoreHolder score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score.Load();
        //Debug.Log( "Score " +score.GetScore(0));
        // ScoreHolder.Instance.Load();
        // ScoreHolder.Instance.GetScore(0);
        Debug.Log( ScoreHolder.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
