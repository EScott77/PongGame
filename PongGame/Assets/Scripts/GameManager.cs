using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour

{
    public Ball ball;
// Text objects 
    public TMPro.TMP_Text p1Text;
    public TMPro.TMP_Text p2Text;
    public TMPro.TMP_Text p1Wins;
    public TMPro.TMP_Text p2Wins; 

    
    //score integers 
private int p1Score;
private int p2Score;


//runs each time player 1 scores
public void p1Scores(){
    p1Score++;  //increase score by 1 
    FindObjectOfType<PongSoundManager>().PlayScore(); //plays sound
    this.p1Text.text = p1Score.ToString();  //updates text to show new score
    if (p1Score == 5){  //if score reaches 5 
        p1Wins.text = "Player 1 Wins!"; //show winning message
        ball.stopBall();    //stops ball from respawning
        FindFirstObjectByType<PongSoundManager>().PlayGameOver();   //plays sound
    }else{ 
    this.ball.ResetPosition();    
    this.ball.AddStartingForce();
    } 

}
//runs each time player 2 scores 
public void p2Scores(){
    p2Score++;  //increase score by 1
    FindObjectOfType<PongSoundManager>().PlayScore();   //plays sound
    this.p2Text.text = p2Score.ToString();      //updates Text to show new score
    if( p2Score == 5){
        p2Wins.text = "Player 2 Wins!"; //show winning messge 
        ball.stopBall();    //stops ball from respawning 
        FindFirstObjectByType<PongSoundManager>().PlayGameOver();   //plays sound 
        
    }else{  // if no one has won, resent ball and start movement 
    this.ball.ResetPosition();
    this.ball.AddStartingForce();
    }
}


}
