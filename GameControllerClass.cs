using UnityEngine;

public class EntityClass
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
}

public class SlimeClass : EntityClass
{
}

public class GoblinClass : EntityClass
{
}

public class GameControllerClass : MonoBehaviour
{
    private void Awake()
    {
        EntityClass entity = new SlimeClass();
        if (entity is SlimeClass)
        {
            Debug.Log("Entity type is Slime");
        }

        GoblinClass goblin = entity as GoblinClass;
        if (goblin == null)
        {
            Debug.Log("goblin is null");
        }
    }
}
