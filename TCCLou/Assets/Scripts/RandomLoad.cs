using UnityEngine;
using UnityEngine.UI;

public class RandomLoad : MonoBehaviour
{

    [SerializeField]
    private Sprite[] _loadings;

    [SerializeField]
    private Image _background;

    private int randInt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randInt = Random.Range(0,_loadings.Length);

        _background.sprite = _loadings[randInt];
    }

    
}
