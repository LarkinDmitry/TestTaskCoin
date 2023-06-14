using UnityEngine;
using UnityEngine.UI;

namespace LarkinTestTask_2_1
{
    public class ColorPreview : MonoBehaviour
    {
        [SerializeField] Image preview;
        [SerializeField] Text red;
        [SerializeField] Text green;
        [SerializeField] Text blue;

        private void Start()
        {
            red.color = Color.red;
            green.color = Color.green;
            blue.color = Color.blue;
        }

        private void OnEnable()
        {
            EventBus.OnChangeColor += UpdateColorInfo;
        }

        private void OnDisable()
        {
            EventBus.OnChangeColor -= UpdateColorInfo;
        }

        private void UpdateColorInfo(Color color)
        {
            preview.color = color;
            red.text = color.r.ToString();
            green.text = color.g.ToString();
            blue.text = color.b.ToString();
        }
    }
}