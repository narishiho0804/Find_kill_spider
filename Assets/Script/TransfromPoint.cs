using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransfromPoint : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        //transform.Rotate(0f, 0f, 0f);
       
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.eulerAngles;

        pos.x = 0;
        pos.z = 0;

        transform.eulerAngles = pos;
    }
}
