using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha10 : MonoBehaviour
{
    int count = 0;

    private void Awake()
    {
        count = 1; // �ʱ�ȭ
    }

    List<string> characterList = new List<string>();

    void Start()
    {
        characterList.Add("���̵� �");

        characterList.Add("����");
        characterList.Add("����");
        characterList.Add("���� ���");
        characterList.Add("�ݷ���");
        characterList.Add("�ٹٶ�");
        characterList.Add("����");
        characterList.Add("�߿�");

        characterList.Add("������ ��");
        characterList.Add("������ Ȱ");
        characterList.Add("������ â");
        characterList.Add("������ ���");
        characterList.Add("������ ������");
        characterList.Add("�亸�Ͽ콺 ��");
        characterList.Add("�亸�Ͽ콺 Ȱ");
        characterList.Add("�亸�Ͽ콺 â");
        characterList.Add("�亸�Ͽ콺 ���");
        characterList.Add("�亸�Ͽ콺 ������");
    }

    public void Gacha()
    {
        int randomValue = Random.Range(0, characterList.Count);

        for (int i = 1; i < 11; i++)
        {
            // count õ��
            if (80 <= count)
            {
                Debug.Log("���̵� ��� �̾Ҵ�!");
                count = 0;
            }


            Debug.Log(characterList[Random.Range(0, characterList.Count)] + "��(��) �̾Ҵ�!");
            count++; // �̱� Ƚ�� ����

        }
    }
}
