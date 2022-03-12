using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace VisualEvents
{
    [CreateAssetMenu(fileName = "VoidEvent", menuName = "ScriptableObjects/VisualEvents/VoidEvent")]
    public class VoidEvent : ScriptableObject
    {
        public UnityAction Event;

        public void Raise()
        {
            Debug.Log("VoidEvent Raised");
            Event?.Invoke();
        }

    }

}
