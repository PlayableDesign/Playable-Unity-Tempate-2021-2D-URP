using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisualEvents
{
    public class EventPublisher : MonoBehaviour
    {
        public VoidEvent voidEvent;


        private void Start()
        {
            StartCoroutine(RaiseEvents());
        }


        private IEnumerator RaiseEvents()
        {
            while (true)
            {
                yield return new WaitForSeconds(3f);
                voidEvent.Raise();
            }

        }

    }

}
