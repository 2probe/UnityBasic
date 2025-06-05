using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Awake()
    {
        //Debug.Log("최초 한 번만 실행됩니다.");
    }

    void OnEnable()
    {
        //Debug.Log("이 오브젝트가 활성화될 때마다 실행됩니다.");
        //Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    }

    // Start is called before the first frame update
    /*void Start()
    {
        //Debug.Log("이 메시지는 게임 시작 시 한 번만 실행됩니다.");
    }
    */

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("매 프레임마다 실행됩니다.");
    }

    void OnDisable()
    {
        //Debug.Log("이 오브젝트가 비활성화될 때마다 실행됩니다.");
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

        void MonsterSpawn() // 몬스터
        {
            B.SetLevel(A.Level());
        }
    }
}