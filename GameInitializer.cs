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
            //  �ùٸ� ���: Player�� GameObject�� �߰� �� Initialize() ���
            Player player = new GameObject("Player").AddComponent<Player>();
            player.Initialize("�����", 100);

            Debug.Log($"{player.ID} HP : {player.CurrentHP}");
        }
    }
}
