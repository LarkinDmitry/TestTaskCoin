using UnityEngine;

namespace LarkinTestTask_2_1
{
    public class Painter : MonoBehaviour
    {
        private Material material;
        private Color targetColor;
        private readonly float changeColorSpeed = 3f;

        void Start()
        {
            material = gameObject.GetComponentInChildren<MeshRenderer>().material;
            SetRandomColor();
        }

        private void Update()
        {
            if (material.color != targetColor)
            {
                material.color = Color.Lerp(material.color, targetColor, changeColorSpeed * Time.deltaTime);
            }
        }

        public void SetRandomColor()
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);

            targetColor = new Color(r, g, b);
            EventBus.OnChangeColor?.Invoke(targetColor);
        }
    }
}