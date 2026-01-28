using UnityEngine;

public class Lab3_GlobalAudio : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0f : 1f;
            Debug.Log(isMuted ? "Audio muted." : "Audio unmuted.");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isPaused)
            {
                AudioListener.pause = true;
                isPaused = true;
                Debug.Log("Audio paused.");
            }
            else
            {
                AudioListener.pause = false;
                isPaused = false;
                Debug.Log("Audio resumed.");
            }
        }
    }
}