using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;

    protected Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }




}
