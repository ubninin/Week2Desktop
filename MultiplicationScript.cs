using UnityEngine;

public class MultiplicationScript : MonoBehaviour
{
    private void Awake()
    {
        // �޼ҵ��� �̸��� �ҷ��� ���
        Multiple(3, 4);
        Multiple(5, 8);
        Multiple(4, 6);
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }
}