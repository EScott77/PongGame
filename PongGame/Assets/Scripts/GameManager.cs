using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour

{
    public Ball ball;

    public TMPro.TMP_Text p1Text;
    public TMPro.TMP_Text p2Text;
    public TMPro.TMP_Text p1Wins;
    public TMPro.TMP_Text p2Wins; 

    
    
private int p1Score;
private int p2Score;

public void p1Scores(){
    p1Score++;
    this.p1Text.text = p1Score.ToString();
    if (p1Score == 5){
        p1Wins.text = "Player 1 Wins!";
        ball.stopBall();
    }else{ 
    this.ball.ResetPosition();    
    this.ball.AddStartingForce();
    } 

}
public void p2Scores(){
    p2Score++;
    this.p2Text.text = p2Score.ToString();
    if( p2Score == 5){
        p2Wins.text = "Player 2 Wins!";
        ball.stopBall();
        
    }else{
    this.ball.ResetPosition();
    this.ball.AddStartingForce();
    }
}


}
