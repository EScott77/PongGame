using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{

  public float bounceStrength;
  public EventTrigger.TriggerEvent scoreTrigger;


//is called when ball object reaches the scoring zone
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null){
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);


        }
    }

    
}
