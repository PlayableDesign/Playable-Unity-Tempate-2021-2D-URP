
using System.Collections;
using UnityEngine;

public class CountdownBehavior : MonoBehaviour
{

    public float Seconds;
    public float Tick;
    public bool CountOnStart;

    public CountDownTickEventSO tickEvent;
    public CountdownCompletedEventSO completeEvent;

    private float _timeRemaining;
    private WaitForSeconds _tick;

    private void Awake()
    {
        _tick = new WaitForSeconds(Tick);
        _timeRemaining = Seconds;
    }

    private void Start()
    {
        if (CountOnStart) StartCoroutine(CountDown());
    }

    public void Count()
    {
        StartCoroutine(CountDown());
    }

    private IEnumerator CountDown()
    {
        while (_timeRemaining > 0)
        {
            yield return _tick;
            _timeRemaining -= Tick;
            tickEvent.Publish?.Invoke();
        }

        completeEvent.Publish?.Invoke();
    }

}
