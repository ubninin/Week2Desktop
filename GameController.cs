using UnityEngine;

public class PlayerEntity
{
    public string ID;
    private int currentHP;

    public PlayerEntity()
    {
        ID = "��ڻ�";
        currentHP = 1000;
    }

    public PlayerEntity(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}

public class GameController : MonoBehaviour
{
    private PlayerEntity player01;
    private PlayerEntity player02;

    private void Awake()
    {
        player01 = new PlayerEntity("��ڻ�", 1000);
        player02 = player01;
        player02.ID = "����Ƽ";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
}
