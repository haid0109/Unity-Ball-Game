using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D RB2D; //creates an instance of the "Rigidbody2D" class

    void Start() //"Start()" is called only once at the very beginning of the game
    {
        RB2D = GetComponent<Rigidbody2D>(); //makes sure the ball gets the "Rigidbody2D" component at the start of the game
    }

    void Update() //"Update()" is called once every frame
    {
        Vector2 ballPosition = new Vector2(0, RB2D.velocity.y); //creates a vector that still allows the gravity physics of "Rigidbody2D" to work

        if (Input.GetKey(KeyCode.RightArrow)) //executes the code below if the "RighArrow"(->) key is pressed
        {
            ballPosition.x = 7; //adds 7 to the balls "x" vector value, which in turn moves it to the right
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ballPosition.x = -7;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) //"GetKeyDown" is different from "GetKey" in that you can't hold the key down
        {                                           //and still get the output, you have to lift your finger from the key before it registers again
            ballPosition.y = 7; //adds 350 to the balls "y" vector force
        }

        RB2D.velocity = ballPosition; //moves the ball
    }
}
