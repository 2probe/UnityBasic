using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Awake()
    {
        //Debug.Log("���� �� ���� ����˴ϴ�.");
    }

    void OnEnable()
    {
        //Debug.Log("�� ������Ʈ�� Ȱ��ȭ�� ������ ����˴ϴ�.");
        //Debug.Log(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
    }

    // Start is called before the first frame update
    /*void Start()
    {
        //Debug.Log("�� �޽����� ���� ���� �� �� ���� ����˴ϴ�.");
    }
    */

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("�� �����Ӹ��� ����˴ϴ�.");
    }

    void OnDisable()
    {
        //Debug.Log("�� ������Ʈ�� ��Ȱ��ȭ�� ������ ����˴ϴ�.");
    }

    public class Player
    {
        private int playerLevel = 10;

        public int Level()
        {
            return playerLevel;
        }
    }

    public class Monster
    {
        private int monsterLevel;

        public void SetLevel(int _playerLevel)
        {
            monsterLevel = _playerLevel;
        }
    }

    public class Game
    {
        Player A;
        Monster B;

        void MonsterSpawn() // ����
        {
            B.SetLevel(A.Level());
        }
    }
}