using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public static arrow destroy; //
    // Start is called before the first frame update
    void Start()
    {
 
        if (destroy != null) // n?u t?n t?i
        {
            Destroy(this.gameObject);// xo� ??i t??ng n�y
            return; // k?t qu? l� null n�n kh�ng l?p l?i h�m if
        }
        destroy = this; //???

        GameObject.DontDestroyOnLoad(this.gameObject); // t?o destroy
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
