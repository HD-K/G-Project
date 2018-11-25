using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class JudgeCheck : MonoBehaviour {
    Image m_Image;
    //Set this in the Inspector
    public Sprite[] m_Sprite=new Sprite[3];

    void Start()
    {
        //Fetch the Image from the GameObject
        m_Image = GetComponent<Image>();
    }

    void Update()
    {
        if (GameManager.instance.JudgeText == "Perfect")
        {
            m_Image.sprite = m_Sprite[0];
        }

    }
}
