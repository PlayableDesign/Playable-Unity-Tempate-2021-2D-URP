
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "MountainGeneratedEventSO", menuName = "ScriptableObjects/MountainGeneratedEventSO")]
public class MountainGeneratedEventSO : ScriptableObject
{
    public UnityEvent OnPublish;
}
