using UnityEngine;
using UnityEngine.Video;

public class Lab5_VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.playOnAwake = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoPlayer.Play();
        }
    }
}