using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    int[] numbers = new int[3];
    List<int> numberList = new List<int>();


    string[] character = { "��Ƽ", "����", "���̵� �", "������", "Ǫ����" };
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


        characterList.Add("��Ƽ");
        characterList.Add("����");
        characterList.Add("���̵� �");
        characterList.Add("������");
        characterList.Add("Ǫ����");
    }

    public void ArrayGacha()
    {
        int randomValue = Random.Range(0, character.Length);

        Debug.Log(character[randomValue] + "��(��) �������ϴ�.");
    }

    public void ListGacha()
    {
        int randomValue = Random.Range(0, characterList.Count);
        Debug.Log(characterList[randomValue] + "��(��) �������ϴ�.");
    }
}
