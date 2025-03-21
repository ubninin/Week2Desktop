using UnityEngine;

namespace MyGame
{
    public class Player : MonoBehaviour
    {
        public int CurrentHP { get; set; }
        public string ID { get; set; }

        public void Initialize(string id, int currentHP)
        {
            ID = id;
            CurrentHP = currentHP;
        }
    }

    public class GameInitializer : MonoBehaviour
    {
        private void Start()
        {
            //  올바른 방법: Player를 GameObject에 추가 후 Initialize() 사용
            Player player = new GameObject("Player").AddComponent<Player>();
            player.Initialize("으어어", 100);

            Debug.Log($"{player.ID} HP : {player.CurrentHP}");
        }
    }
}
