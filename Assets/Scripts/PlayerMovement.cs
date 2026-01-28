using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public AudioSource audioSource;
    public Transform soundEmitter; // Reference to the sound emitter

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.loop = true; // Enable looping for the audio
            audioSource.Play(); // Start playing the audio
        }
    }

    void Update()
    {
        float horizontal = Input.GetKey(KeyCode.RightArrow) ? 1 : Input.GetKey(KeyCode.LeftArrow) ? -1 : 0;
        float vertical = Input.GetKey(KeyCode.UpArrow) ? 1 : Input.GetKey(KeyCode.DownArrow) ? -1 : 0;

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);

        if (soundEmitter != null && audioSource != null)
        {
            float distance = Vector3.Distance(transform.position, soundEmitter.position);
            float volume = Mathf.Clamp01(1 / distance); // Calculate volume based on distance
            audioSource.volume = volume; // Adjust volume dynamically

            Debug.Log($"Player position: {transform.position}, Sound Emitter position: {soundEmitter.position}, Volume: {volume}");
        }
    }
}