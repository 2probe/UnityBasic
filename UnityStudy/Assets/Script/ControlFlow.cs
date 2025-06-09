using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{

    int count = 0;

    private void Awake()
    {
        count = 1; // 초기화
    }
    // Start is called before the first frame update
    void Start()
    {   
        /*
        for(int i = 1; i < 11; i++)
        {
            Debug.Log("반복문 실행: " + i);
        }
        */
    }

    public void Gacha()
    { 
        //확률이 10%면 로그에 '각청'을 뽑았다!
        //확률이 20%면 로그에 '모나'를 뽑았다!
        //확률이 30%면 로그에 '다이루크'를 뽑았다!
        //나머지 40%는 로그에 '치치'를 뽑아버렸다!

        int randomValue = Random.Range(1, 101); // 1부터 100까지의 랜덤 값 생성

        Debug.Log("랜덤 값: " + randomValue);
        Debug.Log("뽑기 횟수: " + count);

        for (int i = 1; i < 11; i++)
        {
            // count 천장
            if (10 <= count)
            {
                Debug.Log("확정으로 각청을 뽑았다!");
                count = 0;
            }

            if (randomValue <= 10)
            {
                Debug.Log("각청을 뽑았다!");
            }

            else if (randomValue <= 30)
            {
                Debug.Log("모나를 뽑았다!");
            }

            else if (randomValue <= 60)
            {
                Debug.Log("다이루크를 뽑았다!");
            }

            else
            {
                Debug.Log("치치를 뽑아버렸다!");
            }

            count++; // 뽑기 횟수 증가
        }
    }

    public int selectNumber = 0;

    public void GachaSwitch()
    {
        int randomValue = Random.Range(1, 101); // 1부터 100까지의 랜덤 값 생성

        

        switch(selectNumber)
        {
            case 0: //아야카
            {
                if (randomValue <= 10)
                {
                    Debug.Log("아야카를 뽑았다!");
                }

                else if (randomValue <= 30)
                {
                    Debug.Log("모나를 뽑았다!");
                }
                else if (randomValue <= 60)
                {
                    Debug.Log("중운을 뽑았다!");
                }
                else
                {
                    Debug.Log("치치를 뽑아버렸다!");
                }
            }
            break;

            case 1: //야에 미코 
            {
                if (randomValue <= 10)
                {
                    Debug.Log("각청을 뽑았다!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("모나를 뽑았다!");
                }
                else if (randomValue <= 60)
                {
                    Debug.Log("응광을 뽑았다!");
                }
                else
                {
                    Debug.Log("치치를 뽑아버렸다!");
                }
            }
            break;

            default: //노엘
            {
                if (randomValue <= 10)
                {
                    Debug.Log("노엘을 뽑았다!");
                }
                else if (randomValue <= 30)
                {
                    Debug.Log("모나를 뽑았다!");
                }
                else if (randomValue <= 60)
                {
                    Debug.Log("다이루크를 뽑았다!");
                }
                else
                {
                    Debug.Log("치치를 뽑아버렸다!");
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
