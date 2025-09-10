using UnityEngine;

public class P2 : Paddle
{
        public  Vector2 direction;  




    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.W))
        // {
        //     direction = Vector2.up;
        // } else if (Input.GetKeyDown(KeyCode.S))
        // {
        //     direction = Vector2.down;
        // } else {
        //     direction = Vector2.zero;

        bool isPressingUp = Input.GetKey(KeyCode.UpArrow);
        bool isPressingDown = Input.GetKey(KeyCode.DownArrow);
        
        if(isPressingUp){
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }
        if(isPressingDown){
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        

        }
    }

    // private void FixedUpdate()
    // {
    //     if (direction != Vector2.zero)
    //     {
    //         rb.AddForce(direction * speed);
    //     }
    // }