using UnityEngine;

namespace LarkinTestTask_2_1
{
    public class Audio : MonoBehaviour
    {
        private AudioSource click;

        private void Awake()
        {
            click = gameObject.AddComponent<AudioSource>();
            click.clip = Resources.Load<AudioClip>("Audio/pop");
            click.playOnAwake = false;
            click.loop = false;
        }

        public void PlayClick()
        {
            click.Play();
        }
    }
}