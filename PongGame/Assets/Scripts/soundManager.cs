using UnityEngine;

public class PongSoundManager : MonoBehaviour
{
    public AudioClip paddleSound;  
    public AudioClip wallSound;
    public AudioClip scoreSound;        
    public AudioClip gameOverSound;     

    private AudioSource audioSource;

    void Awake()
    {

        audioSource = gameObject.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.playOnAwake = false;
    }

    public void PlayPaddleHit()
    {
        audioSource.PlayOneShot(paddleSound);
    }

    public void PlayWallHit(){
        audioSource.PlayOneShot(wallSound);
    }

   
    public void PlayScore()
    {
        audioSource.PlayOneShot(scoreSound);
    }

    public void PlayGameOver()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
}
