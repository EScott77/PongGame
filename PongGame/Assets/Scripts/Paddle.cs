using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;

    protected Rigidbody2D rb;

    //sets all paddles as a rigidbody 
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }




}
