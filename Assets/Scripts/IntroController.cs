using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource bgm;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.Play();
        bgm.Play();
    }

    public void SkipIntro()
    {
        LoadGameplay();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        LoadGameplay();
    }

    void LoadGameplay()
    {
        videoPlayer.Stop();
        bgm.Stop();
        SceneManager.LoadScene("Gameplay");
    }
}
