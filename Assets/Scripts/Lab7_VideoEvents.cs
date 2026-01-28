using UnityEngine;
using UnityEngine.Video;

public class Lab7_VideoEvents : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI;

    void Start()
    {
        endUI.SetActive(false);

        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video prepared");
        vp.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video finished");
        endUI.SetActive(true);
    }
}
