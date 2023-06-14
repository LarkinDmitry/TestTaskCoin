using UnityEngine;

namespace LarkinTestTask_2_1
{
    public class Rotator : MonoBehaviour
    {
        private Vector3 rotation;

        private void Start()
        {
            SetRandomRotation();
        }

        private void Update()
        {
            transform.rotation *= Quaternion.Euler(rotation * Time.deltaTime);
        }

        public void SetRandomRotation()
        {
            float x = Random.Range(30, 50) * (Random.value > 0.5f ? 1 : -1);
            float y = Random.Range(30, 50) * (Random.value > 0.5f ? 1 : -1);
            float z = Random.Range(30, 50) * (Random.value > 0.5f ? 1 : -1);

            rotation = new(x, y, z);
        }
    }
}