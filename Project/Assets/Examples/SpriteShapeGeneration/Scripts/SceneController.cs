
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public MountainGeneratedEventSO mountainGeneratedEvent;

    private void OnEnable()
    {
        mountainGeneratedEvent.Publish += OnMountainGenerated;
    }

    private void OnDisable()
    {
        mountainGeneratedEvent.Publish -= OnMountainGenerated;
    }

    public void OnMountainGenerated()
    {
        Debug.Log("Mountain done generated y'all");
    }
}