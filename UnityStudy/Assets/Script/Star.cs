using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{

    /* 1. string.Empty
     string ������ ���� �ʱ�ȭ �մϴ�.
    string star;
    star = string.Empty;

    2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
    Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    star += "��"; // ��
    star += "��"; // ��ĭ
    star += "\n"; // �ٹٲ�

    3. Debug.Log("");
    Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    Debug.Log(star);
    */

    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;

        // ������ 1

        for (int i = 0; i < 5; i++) //0,1,2,3,4 �� 5���� ���� ����� for��
        {   
            for (int j = 0; j < 1+i; j++) //���� �þ ������ ���� ������ �þ�� for��, 1�� ���� ����
            {
                star += "��";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2

        for (int i = 0; i < 5; i++)
        {
            for (int k = 0; k < +i; k++) //���� �þ ������ ��ĭ�� ������ �þ�� for��, 0���� ����
            {
                star += "��";
            }
            for (int j = 0; j < 5 - i; j++) //���� �þ ������ ���� ������ �پ��� for��
            {
                star += "��";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3

        for (int i = 0; i < 5; i++) //�ϴ� 5�� ���� ����
        {
            for (int j = 0; j < 1+i; j++)
            {
                star += "��";
            }
            star += "\n";
        }

        for (int i = 0; i < 4; i++) //������ 4�� ����
        {
            for (int j = 0; j < 4-i; j++)
            {
                star += "��";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4

        for (int i = 0; i < 5; i++) //�ϴ� 5�� ���� ����
        {
            for (int k = 0; k < 4-i; k++) //��ĭ 4������ �����ؼ� ���� �þ ������ ��ĭ�� ������ �پ��� for��
            {
                star += "��";
            }

            for (int j = 0; j < 1 + i; j++) //���� �þ ������ ���� ������ �þ�� for��, 1�� ���� ����
            {
                star += "��";
            }
            star += "\n";
        }

        for (int i = 0; i < 4; i++) //������ 4�� ����
        {
            for (int k = 0; k < 1+i; k++) //���� �þ ������ ��ĭ�� ������ �þ�� for��, 0���� ����
            {
                star += "��";
            }
            for (int j = 0; j < 4-i; j++) //���� �þ ������ ���� ������ �پ��� for��
            {
                star += "��";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5

        for (int i = 0; i < 5; i++) //�ϴ� 5�� ���� ����
        {
            for (int k = 0; k < 4 - i; k++) //��ĭ 4������ �����ؼ� ���� �þ ������ ��ĭ�� ������ �پ��� for��
            {
                star += "��";
            }

            for (int j = 0; j < 1 + i*2; j++) //���� �þ ������ ���� ������ ix2���� �þ�� for��, �ʱⰪ�� 1��
            {
                star += "��";
            }
            star += "\n";
        }

        for (int i = 0; i < 4; i++) //������ 4�� ����
        {
            for (int k = 0; k < 1 + i; k++) //��ĭ 1������ �����ؼ� ���� �þ ������ ��ĭ�� ������ �þ�� for��
            {
                star += "��";
            }
            for (int j = 0; j < 7 - i*2; j++) //���� �þ ������ ���� ������ ix2�� �پ��� for��, �ʱⰪ�� 7��
            {
                star += "��";
            }
            star += "\n";
        }
        Debug.Log(star);
    }



    void Update()
    {
        
    }
}
