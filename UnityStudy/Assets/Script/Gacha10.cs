using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha10 : MonoBehaviour
{
    int count = 0;

    private void Awake()
    {
        count = 1; // 초기화
    }

    List<string> characterList = new List<string>();

    void Start()
    {
        characterList.Add("라이덴 쇼군");

        characterList.Add("설탕");
        characterList.Add("응광");
        characterList.Add("쿠죠 사라");
        characterList.Add("콜레이");
        characterList.Add("바바라");
        characterList.Add("엠버");
        characterList.Add("중운");

        characterList.Add("연습용 검");
        characterList.Add("연습용 활");
        characterList.Add("연습용 창");
        characterList.Add("연습용 대검");
        characterList.Add("연습용 마도서");
        characterList.Add("페보니우스 검");
        characterList.Add("페보니우스 활");
        characterList.Add("페보니우스 창");
        characterList.Add("페보니우스 대검");
        characterList.Add("페보니우스 마도서");
    }

    public void Gacha()
    {
        int randomValue = Random.Range(0, characterList.Count);

        for (int i = 1; i < 11; i++)
        {
            // count 천장
            if (80 <= count)
            {
                Debug.Log("라이덴 쇼군을 뽑았다!");
                count = 0;
            }


            Debug.Log(characterList[Random.Range(0, characterList.Count)] + "을(를) 뽑았다!");
            count++; // 뽑기 횟수 증가

        }
    }
}
