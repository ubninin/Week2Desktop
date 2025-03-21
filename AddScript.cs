using UnityEngine;

public class AddScript : MonoBehaviour
{
    private void Awake()
    {
        int a = 3, b = 4;
        Add(a, b);
    }

    public void Add(int num1, int num2)
    {
        int result = num1 + num2;
        Debug.Log($"{num1} + {num2} = {result}");
    }
}