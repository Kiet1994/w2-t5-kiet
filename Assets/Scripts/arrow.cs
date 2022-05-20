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
            Destroy(this.gameObject);// xoá ??i t??ng này
            return; // k?t qu? là null nên không l?p l?i hàm if
        }
        destroy = this; //???

        GameObject.DontDestroyOnLoad(this.gameObject); // t?o destroy
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
