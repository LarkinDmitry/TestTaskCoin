using UnityEngine;

namespace LarkinTestTask_2_1
{
    // Hi, friend!
    // Of course, this simple program does not require
    // the use of delegates or any other complexities,
    // but this is a test task... why not? ;)

    // A simplified version of the "EventBus pattern"
    // is used to communicate with the UI.


    public class Main : MonoBehaviour
    {
        [SerializeField] private GameObject coinPrefab;

        private GameObject coin;
        private Audio sound;

        private void Start()
        {
            sound = gameObject.AddComponent<Audio>();
            CreateCoin();
        }

        private void CreateCoin()
        {
            coin = Instantiate(coinPrefab);
            coin.name = "Coin";

            Rotator rotator = coin.AddComponent<Rotator>();
            Painter painter = coin.AddComponent<Painter>();
            Clickable clickable = coin.AddComponent<Clickable>();

            clickable.SubscribeOnClick(sound.PlayClick);
            clickable.SubscribeOnClick(rotator.SetRandomRotation);
            clickable.SubscribeOnClick(painter.SetRandomColor);
        }
    }
}