using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.
    public Text scoreText; //점수를 표시하는 Text객체를 에디터에서 받아옵니다.
    public string JudgeText; //판정을 표시하는 Text
    public Image sprite;
    public Text ComboText; //콤보를 표시
    public int combo = 0;
    public int n;
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites = new Sprite[10];                //이미지 목록 

    public int score = 0; //점수를 관리합니다.

    void Awake()
    {
        if (!instance) //정적으로 자신을 체크합니다.
            instance = this; //정적으로 자신을 저장합니다.
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void Judge(string note)
    {
        JudgeText = note;
    }
    public void AddCombo()
    {
        combo += 1;
        //ComboText.text = combo.ToString();
    }
    public void AddScore(int num) //점수를 추가해주는 함수를 만들어 줍니다.
    {
        
        score += num;
        //scoreText.text = score.ToString();
        //gameObject.GetComponent<Image>().sprite = sprites[n]; //이미지 변경 
    }
    public void MissScore()
    {
        score = 0;
    }

}
