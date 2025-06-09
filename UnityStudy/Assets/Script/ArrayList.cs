using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    int[] numbers = new int[3];
    List<int> numberList = new List<int>();


    string[] character = { "º¥Æ¼", "Á¾·Á", "¶óÀÌµ§ ¼î±º", "³ªÈ÷´Ù", "Çª¸®³ª" };
    List<string> characterList = new List<string>();

    void Start()
    {
        numbers[0] = 100;
        numbers[1] = 200;
        numbers[2] = 300;


        numberList.Add(100);
        numberList.Add(200);
        numberList.Add(300);
        numberList.Add(400);
        numberList.Add(500);

        Debug.Log("numbers : " + numbers[2]);
        Debug.Log("numberList : " + numberList[4]);


        characterList.Add("º¥Æ¼");
        characterList.Add("Á¾·Á");
        characterList.Add("¶óÀÌµ§ ¼î±º");
        characterList.Add("³ªÈ÷´Ù");
        characterList.Add("Çª¸®³ª");
    }

    public void ArrayGacha()
    {
        int randomValue = Random.Range(0, character.Length);

        Debug.Log(character[randomValue] + "ÀÌ(°¡) »ÌÇû½À´Ï´Ù.");
    }

    public void ListGacha()
    {
        int randomValue = Random.Range(0, characterList.Count);
        Debug.Log(characterList[randomValue] + "ÀÌ(°¡) »ÌÇû½À´Ï´Ù.");
    }
}
