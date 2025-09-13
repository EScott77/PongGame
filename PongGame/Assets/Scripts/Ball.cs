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

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x,y);


        rb.AddForce(direction *speed);
    }

    public void AddForce( Vector2 force){
        rb.AddForce(force);
    }
    public void stopBall(){
        gameObject.SetActive(false);
    }



    
    
}
