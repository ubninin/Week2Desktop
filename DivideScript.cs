using UnityEngine;

public class DivideScript : MonoBehaviour
{
    public void Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            Debug.Log("�������� ���� 0�̱� ������ ���α׷� ����");
            return;
        }

        float result = (float)num1 / num2;
        Debug.Log($"{num1} / {num2} = {result}");
    }
}