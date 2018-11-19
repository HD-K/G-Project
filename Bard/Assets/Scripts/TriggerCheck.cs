using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCheck : MonoBehaviour
{

    private float _notePosX;
    private float _playerPosX;
    private BoxCollider2D _boxCollider2D;
    private Transform _transform;
    private int resultIdx;
    Vector3 pos;

    // Use this for initialization
    void Start()
    {

        _boxCollider2D = GetComponent<BoxCollider2D>();
        _playerPosX = 7.0f;
        _transform = transform;
        _notePosX = _transform.position.x;

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag=="Note"){
            Debug.Log("OK");
            
        }
    }
    void Check()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos=this.gameObject.transform.position;
            if (pos.x > 1)
            //if(Time.deltaTime>0.1)
            {
                GameManager.instance.AddScore(0);
                GameManager.instance.Judge("Miss");
                return;
            }
            else if (pos.x < 0.4)
            {
                GameManager.instance.AddScore(200);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Perfect");
                gameObject.SetActive(false);
            }
            else
            {
                GameManager.instance.AddScore(140);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Good");
                gameObject.SetActive(false);
            }
        }

    }



}
