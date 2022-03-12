using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisualEvents
{
    public class EventSubscriber : MonoBehaviour
    {
        public VoidEvent voidEvent;

        private void OnEnable()
        {
            voidEvent.Event += OnPublishVoidEvent;
        }

        private void OnDisable()
        {
            voidEvent.Event -= OnPublishVoidEvent;
        }

        public void OnPublishVoidEvent()
        {
            Debug.Log("VOIDEVENTED");
        }
    }

}
