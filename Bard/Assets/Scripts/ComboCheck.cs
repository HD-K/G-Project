using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ComboCheck : MonoBehaviour {

    public int n;
    private int n1 = 0;
    private SpriteRenderer spriteRenderer;
    private int combo = 0;
    public Sprite[] sprites = new Sprite[10];

    // Use this for initialization
    void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        combo = GameManager.instance.combo;
        n1 = combo / n;
        gameObject.GetComponent<Image>().sprite = sprites[n1 % 10]; //이미지 변경 
    }
}
