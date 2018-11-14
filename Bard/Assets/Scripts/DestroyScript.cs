using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

    public void OnEnable()
    {
        Invoke("OnDestroy", 8.0f);    
    }

    void OnDestroy()
    {
        gameObject.SetActive(false);
    }
    void OnDisable()
    {
        CancelInvoke();
    }

}
