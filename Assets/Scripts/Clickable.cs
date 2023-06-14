using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace LarkinTestTask_2_1
{
    public class Clickable : MonoBehaviour, IPointerClickHandler
    {
        public delegate void OnClickSubscriber();
        List<OnClickSubscriber> clickSubscribers = new();

        public void SubscribeOnClick(OnClickSubscriber func)
        {
            clickSubscribers.Add(func);
        }

        public void UnsubscribeOnClick(OnClickSubscriber func)
        {
            clickSubscribers.Remove(func);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            clickSubscribers.ForEach(f => f?.Invoke());
        }

        private void OnDestroy()
        {
            clickSubscribers.Clear();
        }
    }
}