using UnityEngine;
using UnityEngine.UIElements;

public class MusicManager : MonoBehaviour
{
    private static MusicManager backgroundMusic;
    void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
