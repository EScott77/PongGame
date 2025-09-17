using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    public float baseSpeed = 5f;
    public float currentSpeed{get; set; }


    public scoreScript score;

    private Rigidbody2D rb;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

// method for restarting the round 
    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("logic").GetComponent<scoreScript>();

        ResetPosition();
        AddStartingForce();
    }


    public void ResetPosition(){
        rb.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;


    }

    // star of each round, ball moves at random range. new direction each round
    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x,y);


        rb.AddForce(direction *speed);
    }
    //add force to object upon call 
    public void AddForce( Vector2 force){
        rb.AddForce(force);
    }
    // method to stop ball from moving for when game ends
    public void stopBall(){
        gameObject.SetActive(false);
    }


    // upon collision, play appropriate sound based off of object type

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Paddle")){
            FindFirstObjectByType<PongSoundManager>().PlayPaddleHit();
        }if (collision.gameObject.CompareTag("Wall")){
            FindFirstObjectByType<PongSoundManager>().PlayWallHit();
        }

    }



    
    
}
