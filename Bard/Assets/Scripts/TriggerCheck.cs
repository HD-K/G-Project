using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCheck : MonoBehaviour
{

    private float _notePosX;
    private float _playerPosX;
    private float distance;
    public BoxCollider _boxCollider;
    private Transform _transform;
    private int resultIdx;
    Vector3 pos;
    public Sprite[] sprites=new Sprite[3];

    // Use this for initialization
    void Start()
    {

        _boxCollider = GetComponent<BoxCollider>();
        _playerPosX = 7.0f;
        _transform = transform;
        _notePosX = _transform.position.x;

    }
    void Update()
    {
        Check();
    }
/*
        void OnTriggerEnter(Collider collision)
        {
                distance = Vector3.Distance(gameObject.transform.position, collision.transform.position);
                //if (gameObject.transform.position.x < 0.2f && gameObject.transform.position.x>0.06f)
                if(collision.gameObject.tag=="Collider")
                {
                        Debug.Log("OK");

                    //Debug.Log(gameObject.transform.position);
                    GameManager.instance.AddScore(200);
                    GameManager.instance.AddCombo();
                    GameManager.instance.Judge("Perfect");

        }

                //gameObject.SetActive(false);
                //판정 콜라이더를 4개 만든다 Perfect, Good, 나머지는 Miss
                //첫번째 안 : 노트와 충돌한 현재 충돌박스가 몇개?
                //박스 종류: P=Perfect 콜라이더 / G=Good 콜라이더 / M=Miss 콜라이더
                //Perfect: P=True & G=True & M=True
                //Good: P=False & G=True & M=True
                //Miss: P=False & G=False & M=True

                //두 번째 안
                //현재 노드가 있는 부분이 어디에 가까운지 비교하여 판정
        }
*/
    void Check()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (gameObject.transform.position.x > 0.0f && gameObject.transform.position.x < 0.5f&&gameObject.transform.position.y==-1.8f)
            {
                Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(200);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Perfect");
                Destroy(gameObject);
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (gameObject.transform.position.x > 0.0f && gameObject.transform.position.x < 0.5f && gameObject.transform.position.y == -2.25f)
            {
                Debug.Log(gameObject.transform.position.y);
                //Debug.Log(gameObject.transform.position);
                GameManager.instance.AddScore(200);
                GameManager.instance.AddCombo();
                GameManager.instance.Judge("Perfect");
                Destroy(gameObject);
            }
        }
        
    }

    }
