using UnityEngine;

public class PongSoundManager : MonoBehaviour
{

    //all audio clips 
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

//paddle sound
    public void PlayPaddleHit()
    {
        audioSource.PlayOneShot(paddleSound);
    }

//wall sound
    public void PlayWallHit(){
        audioSource.PlayOneShot(wallSound);
    }

   //scoring sound
    public void PlayScore()
    {
        audioSource.PlayOneShot(scoreSound);
    }
//game over sound
    public void PlayGameOver()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
}
