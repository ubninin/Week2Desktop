using UnityEngine;

public class Entity : MonoBehaviour
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}

public class Player : Entity
{
    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
        RecoveryHP(1000);
        // private�̱� ������ ��� �Ұ� Initialize();
    }
}
