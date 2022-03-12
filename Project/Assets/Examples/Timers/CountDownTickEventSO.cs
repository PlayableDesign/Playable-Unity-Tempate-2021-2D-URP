
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CountDownTickEventSO", menuName = "ScriptableObjects/CountDownTickEventSO")]
public class CountDownTickEventSO : ScriptableObject
{
    public Action Publish;
}
