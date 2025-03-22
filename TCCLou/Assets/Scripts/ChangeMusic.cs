using UnityEngine;
using Mkey;

public class ChangeMusic : MonoBehaviour
{

    public int music;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SoundMaster.Instance.ChangeMusic(music);
        if(music == 1)
        SoundMaster.Instance.SetMusicAndPlay(SoundMaster.Instance.gameMusic);
        if(music == 0)
        SoundMaster.Instance.SetMusicAndPlay(SoundMaster.Instance.mapMusic);
        SoundMaster.Instance.PlayCurrentMusic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
