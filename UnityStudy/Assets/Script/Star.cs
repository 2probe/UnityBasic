using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{

    /* 1. string.Empty
     string 변수의 값을 초기화 합니다.
    string star;
    star = string.Empty;

    2. 별, 빈칸, 줄바꿈 추가하기
    Debug.Log를 사용하여 콘솔창에 출력합니다
    star += "★"; // 별
    star += "　"; // 빈칸
    star += "\n"; // 줄바꿈

    3. Debug.Log("");
    Debug.Log를 사용하여 콘솔창에 출력합니다
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

        // 페이즈 1

        for (int i = 0; i < 5; i++) //0,1,2,3,4 총 5개의 행을 만드는 for문
        {   
            for (int j = 0; j < 1+i; j++) //행이 늘어날 때마다 별의 개수가 늘어나는 for문, 1개 부터 시작
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2

        for (int i = 0; i < 5; i++)
        {
            for (int k = 0; k < +i; k++) //행이 늘어날 때마다 빈칸의 개수가 늘어나는 for문, 0부터 시작
            {
                star += "　";
            }
            for (int j = 0; j < 5 - i; j++) //행이 늘어날 때마다 별의 개수가 줄어드는 for문
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3

        for (int i = 0; i < 5; i++) //일단 5행 먼저 생성
        {
            for (int j = 0; j < 1+i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = 0; i < 4; i++) //나머지 4행 생성
        {
            for (int j = 0; j < 4-i; j++)
            {
                star += "★";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4

        for (int i = 0; i < 5; i++) //일단 5행 먼저 생성
        {
            for (int k = 0; k < 4-i; k++) //빈칸 4개부터 시작해서 행이 늘어날 때마다 빈칸의 개수가 줄어드는 for문
            {
                star += "　";
            }

            for (int j = 0; j < 1 + i; j++) //행이 늘어날 때마다 별의 개수가 늘어나는 for문, 1개 부터 시작
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = 0; i < 4; i++) //나머지 4행 생성
        {
            for (int k = 0; k < 1+i; k++) //행이 늘어날 때마다 빈칸의 개수가 늘어나는 for문, 0부터 시작
            {
                star += "　";
            }
            for (int j = 0; j < 4-i; j++) //행이 늘어날 때마다 별의 개수가 줄어드는 for문
            {
                star += "★";
            }
            star += "\n";
        }


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5

        for (int i = 0; i < 5; i++) //일단 5행 먼저 생성
        {
            for (int k = 0; k < 4 - i; k++) //빈칸 4개부터 시작해서 행이 늘어날 때마다 빈칸의 개수가 줄어드는 for문
            {
                star += "　";
            }

            for (int j = 0; j < 1 + i*2; j++) //행이 늘어날 때마다 별의 개수가 ix2개씩 늘어나는 for문, 초기값은 1개
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = 0; i < 4; i++) //나머지 4행 생성
        {
            for (int k = 0; k < 1 + i; k++) //빈칸 1개부터 시작해서 행이 늘어날 때마다 빈칸의 개수가 늘어나는 for문
            {
                star += "　";
            }
            for (int j = 0; j < 7 - i*2; j++) //행이 늘어날 때마다 별의 개수가 ix2씩 줄어드는 for문, 초기값은 7개
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }



    void Update()
    {
        
    }
}
