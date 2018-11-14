using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCheck : MonoBehaviour {
    public int n;
    private int n1=0;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites = new Sprite[10];
    public static GameManager instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.

    private int score = 0; //점수를 관리합니다.

    // Use this for initialization
    void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }
    void Update() //점수를 추가해주는 함수를 만들어 줍니다.
    {
        score = GameManager.instance.score;
        n1 = score / n;

        gameObject.GetComponent<Image>().sprite = sprites[n1%10]; //이미지 변경 
    }

}
