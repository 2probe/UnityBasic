using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{

    int count = 0;

    private void Awake()
    {
        count = 1; // �ʱ�ȭ
    }
    // Start is called before the first frame update
    void Start()
    {   
        /*
        for(int i = 1; i < 11; i++)
        {
            Debug.Log("�ݺ��� ����: " + i);
        }
        */
    }

    public void Gacha()
    { 
        //Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        //Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        //Ȯ���� 30%�� �α׿� '���̷�ũ'�� �̾Ҵ�!
        //������ 40%�� �α׿� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = Random.Range(1, 101); // 1���� 100������ ���� �� ����

        Debug.Log("���� ��: " + randomValue);
        Debug.Log("�̱� Ƚ��: " + count);

        for (int i = 1; i < 11; i++)
        {
            // count õ��
            if (10 <= count)
            {
                Debug.Log("Ȯ������ ��û�� �̾Ҵ�!");
                count = 0;
            }

            if (randomValue <= 10)
            {
                Debug.Log("��û�� �̾Ҵ�!");
            }

            else if (randomValue <= 30)
            {
                Debug.Log("�𳪸� �̾Ҵ�!");
            }

            else if (randomValue <= 60)
            {
                Debug.Log("���̷�ũ�� �̾Ҵ�!");
            }

            else
            {
                Debug.Log("ġġ�� �̾ƹ��ȴ�!");
            }

            count++; // �̱� Ƚ�� ����
        }
    }

    public int selectNumber = 0;

    public void GachaSwitch()
    {
        int randomValue = Random.Range(1, 101); // 1���� 100������ ���� �� ����

        

        switch(selectNumber)
        {
            case 0: //�ƾ�ī
            {
                if (randomValue <= 10)
                {
                    Debug.Log("�ƾ�ī�� �̾Ҵ�!");
                }

                else if (randomValue <= 30)
                {
                    Debug.Log("�𳪸� �̾Ҵ�!");
                }
                else if (randomValue <= 60)
                {
                    Debug.Log("�߿��� �̾Ҵ�!");
                }
                else
                {
                    Debug.Log("ġġ�� �̾ƹ��ȴ�!");
                }
            }
            break;

            case 1: //�߿� ���� 
            {
                if (randomValue <= 10)
                {
                    Debug.Log("��û�� �̾Ҵ�!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("�𳪸� �̾Ҵ�!");
                }
                else if (randomValue <= 60)
                {
                    Debug.Log("������ �̾Ҵ�!");
                }
                else
                {
                    Debug.Log("ġġ�� �̾ƹ��ȴ�!");
                }
            }
            break;

            default: //�뿤
            {
                if (randomValue <= 10)
                {
                    Debug.Log("�뿤�� �̾Ҵ�!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("�𳪸� �̾Ҵ�!");
                }
                else if (randomValue <= 60)
                {
                    Debug.Log("���̷�ũ�� �̾Ҵ�!");
                }
                else
                {
                    Debug.Log("ġġ�� �̾ƹ��ȴ�!");
                }
            }
            break;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
