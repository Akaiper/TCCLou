using UnityEngine;

/*
  26.11.2019 - first
 */
namespace Mkey
{
  public class StartSound : MonoBehaviour
  {
    [SerializeField]
    private AudioClip startClip;

    public bool isRandom;
    public AudioClip[] randomClips;

    [SerializeField]
    private float delay;

    #region temp vars
    private SoundMaster MSound { get { return SoundMaster.Instance; } }
    #endregion temp vars

    void Start()
    {
      if (MSound)
      {
        if (!isRandom)
        {
          MSound.PlayClip(delay, startClip);
        }
        else
        {
          MSound.PlayClip(delay, randomClips[Random.Range(0, randomClips.Length)]);
        }
      }
        
    }
  }
}
