using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leeprobe : MonoBehaviour
{
    private new string name = "�̽���";
    private string gender = "����";
    private int age = 25;
    private int height = 181;
    private int weight = 65;
    private string job = "��ȹ ������";
    private string hobby = "����, ��ȭ, ����, �۾���";
    private string favoriteGame = "World of Warcraft";
    private string favoriteGameGenre = "MMORPG";
    private string favoriteFood = "�������";
    private string favoriteColor = "���̺�";
    private string favoriteSinger = "�ܳ���";
    private string favoriteMovie = "LA LA LAND";
    private string favoriteBook = "�ظ����� �ø���";
    private string mbtiType = "INTJ";

    void Start()
    {
        SelfIntro();
        SelfIntro(name, gender, age, height, weight, job, hobby, favoriteGame, favoriteGameGenre, favoriteFood, favoriteColor, favoriteSinger, favoriteMovie, favoriteBook, mbtiType);
    }
    public void SelfIntro()
    {
        Debug.Log("�ȳ��ϼ���, �� �̸��� " + name + "�Դϴ�.");
        Debug.Log("���� " + gender + "�̱���");
        Debug.Log("���̴� " + age + "���Դϴ�.");
        Debug.Log("Ű�� " + height + "cm, �����Դ� " + weight + "kg�Դϴ�.");
        Debug.Log("������ " + job + "�̰�, ��̴� " + hobby + "�Դϴ�.");
        Debug.Log("���� �����ϴ� ������ " + favoriteGame + "�̰�, �帣�� " + favoriteGameGenre + "�Դϴ�.");
        Debug.Log("�����ϴ� ������ " + favoriteFood + "�̰�, �����ϴ� ������ " + favoriteColor + "�Դϴ�.");
        Debug.Log("�����ϴ� ������ " + favoriteSinger + "�̰�, �����ϴ� ��ȭ�� " + favoriteMovie + "�Դϴ�.");
        Debug.Log("�����ϴ� å�� " + favoriteBook + "�̰�, MBTI�� " + mbtiType + "�Դϴ�.");
    }

    public void SelfIntro(string _name, string _gender, int _age, int _height, int _weight, string _job, string _hobby, string _favoriteGame, string _favoriteGameGenre, string _favoriteFood, string _favoriteColor, string _favoriteSinger, string _favoriteMovie, string _favoriteBook, string _mbtiType)
    {
        Debug.Log("�ȳ��ϼ���, �� �̸��� " + _name + "�Դϴ�.");
        Debug.Log("���� ������ " + _gender + "�Դϴ�.");
        Debug.Log($"���̴� {age}���Դϴ�.");
        Debug.Log($"Ű�� {_height}cm, �����Դ� {_weight}kg�Դϴ�.");
        Debug.Log($"������ {_job}�̰�, ��̴� {_hobby}�Դϴ�.");
        Debug.Log($"���� �����ϴ� ������ {_favoriteGame}�̰�, �帣�� {_favoriteGameGenre}�Դϴ�.");
        Debug.Log($"�����ϴ� ������ {_favoriteFood}�̰�, �����ϴ� ������ {_favoriteColor}�Դϴ�.");
        Debug.Log($"�����ϴ� ������ {_favoriteSinger}�̰�, �����ϴ� ��ȭ�� {_favoriteMovie}�Դϴ�.");
        Debug.Log($"�����ϴ� å�� {_favoriteBook}�̰�, MBTI�� {_mbtiType}�Դϴ�.");
    }
}