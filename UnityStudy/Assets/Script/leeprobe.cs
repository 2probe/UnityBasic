using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leeprobe : MonoBehaviour
{
    private new string name = "이승준";
    private string gender = "남성";
    private int age = 25;
    private int height = 181;
    private int weight = 65;
    private string job = "기획 지망생";
    private string hobby = "게임, 영화, 독서, 글쓰기";
    private string favoriteGame = "World of Warcraft";
    private string favoriteGameGenre = "MMORPG";
    private string favoriteFood = "돼지고기";
    private string favoriteColor = "네이비";
    private string favoriteSinger = "잔나비";
    private string favoriteMovie = "LA LA LAND";
    private string favoriteBook = "해리포터 시리즈";
    private string mbtiType = "INTJ";

    void Start()
    {
        SelfIntro();
        SelfIntro(name, gender, age, height, weight, job, hobby, favoriteGame, favoriteGameGenre, favoriteFood, favoriteColor, favoriteSinger, favoriteMovie, favoriteBook, mbtiType);
    }
    public void SelfIntro()
    {
        Debug.Log("안녕하세요, 제 이름은 " + name + "입니다.");
        Debug.Log("저는 " + gender + "이구요");
        Debug.Log("나이는 " + age + "세입니다.");
        Debug.Log("키는 " + height + "cm, 몸무게는 " + weight + "kg입니다.");
        Debug.Log("직업은 " + job + "이고, 취미는 " + hobby + "입니다.");
        Debug.Log("제가 좋아하는 게임은 " + favoriteGame + "이고, 장르는 " + favoriteGameGenre + "입니다.");
        Debug.Log("좋아하는 음식은 " + favoriteFood + "이고, 좋아하는 색깔은 " + favoriteColor + "입니다.");
        Debug.Log("좋아하는 가수는 " + favoriteSinger + "이고, 좋아하는 영화는 " + favoriteMovie + "입니다.");
        Debug.Log("좋아하는 책은 " + favoriteBook + "이고, MBTI는 " + mbtiType + "입니다.");
    }

    public void SelfIntro(string _name, string _gender, int _age, int _height, int _weight, string _job, string _hobby, string _favoriteGame, string _favoriteGameGenre, string _favoriteFood, string _favoriteColor, string _favoriteSinger, string _favoriteMovie, string _favoriteBook, string _mbtiType)
    {
        Debug.Log("안녕하세요, 제 이름은 " + _name + "입니다.");
        Debug.Log("저의 성별은 " + _gender + "입니다.");
        Debug.Log($"나이는 {age}세입니다.");
        Debug.Log($"키는 {_height}cm, 몸무게는 {_weight}kg입니다.");
        Debug.Log($"직업은 {_job}이고, 취미는 {_hobby}입니다.");
        Debug.Log($"제가 좋아하는 게임은 {_favoriteGame}이고, 장르는 {_favoriteGameGenre}입니다.");
        Debug.Log($"좋아하는 음식은 {_favoriteFood}이고, 좋아하는 색깔은 {_favoriteColor}입니다.");
        Debug.Log($"좋아하는 가수는 {_favoriteSinger}이고, 좋아하는 영화는 {_favoriteMovie}입니다.");
        Debug.Log($"좋아하는 책은 {_favoriteBook}이고, MBTI는 {_mbtiType}입니다.");
    }
}