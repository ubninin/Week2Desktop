using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiply(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} x {num2} = {result}");
    }

    // Unity의 Start 메서드에서 테스트
    void Start()
    {
        int sum = Add(5, 10);
        Debug.Log($"5 + 10 = {sum}");

        Multiply(5, 10);
    }
}
