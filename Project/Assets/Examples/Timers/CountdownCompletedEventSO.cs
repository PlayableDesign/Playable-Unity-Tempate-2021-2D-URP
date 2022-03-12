
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CountdownCompletedEventSO", menuName = "ScriptableObjects/CountdownCompletedEventSO")]
public class CountdownCompletedEventSO : ScriptableObject
{
    public Action Publish;
}


