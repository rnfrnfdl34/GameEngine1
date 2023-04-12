using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int j = 0;
        for(int i=1; i<11; i++){
            j+=i;
            
        }
        Debug.Log(j);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
