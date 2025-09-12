using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour

{
    public Ball ball;

    public TMPro.TMP_Text p1Text;
    public TMPro.TMP_Text p2Text;

    
private int p1Score;
private int p2Score;

public void p1Scores(){
    p1Score++;
    this.p1Text.text = p1Score.ToString();
    this.ball.ResetPosition();
    this.ball.AddStartingForce();


}
public void p2Scores(){
    p2Score++;
    this.p2Text.text = p2Score.ToString();
    this.ball.ResetPosition();
    this.ball.AddStartingForce();

}


}
