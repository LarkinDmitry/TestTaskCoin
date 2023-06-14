using System;
using UnityEngine;

namespace LarkinTestTask_2_1
{
    public static class EventBus
    {
        public static Action<Color> OnChangeColor { get; set; }
    }
}