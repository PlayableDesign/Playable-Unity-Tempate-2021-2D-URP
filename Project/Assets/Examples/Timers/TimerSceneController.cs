
using UnityEngine;

public class TimerSceneController : MonoBehaviour
{
    public CountdownCompletedEventSO CompletedEvent;
    public CountDownTickEventSO TickEvent;

    private void OnEnable()
    {
        CompletedEvent.Publish += OnCountdownCompleted;
        TickEvent.Publish += OnTickCompleted;
    }

    private void OnDisable()
    {
        CompletedEvent.Publish -= OnCountdownCompleted;
        TickEvent.Publish -= OnTickCompleted;
    }

    private void OnCountdownCompleted()
    {
        Debug.Log("Countdown done did completed y'all");
    }

    private void OnTickCompleted()
    {
        Debug.Log("Tick done happened y'all");
    }

}