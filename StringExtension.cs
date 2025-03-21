using MyUtility;
using UnityEngine;

namespace MyUtility
{
    public static class StringExtension
    {
        public static void PrintData(this string str)
        {
            Debug.Log(str);
        }
    }
}

namespace MyGame
{
    public class GameController : MonoBehaviour
    {
        private void Start()
        {
            string str = "안녕하세요. 고박사입니다.";
            StringExtension.PrintData(str);
        }
    }
}
