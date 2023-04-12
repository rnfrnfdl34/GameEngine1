using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InchToCm
{
    public float inch;
    public void ConvertToCm()
    {

        float cm = inch * 2.54f;
        Debug.Log(cm);
    }
}

public class Ex07 : MonoBehaviour
{ 
   
    void Start()
    {
     
        InchToCm converter = new InchToCm();

        converter.inch = 10.0f;
        converter.ConvertToCm();



    }

    private void Update()
    {
        
    }


}

