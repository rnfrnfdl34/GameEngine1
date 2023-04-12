using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
    [SerializeField]
    public int input_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(input_score>=80)
            Debug.Log("우수");

        else if(input_score>=60)
            Debug.Log("보통");

        else
            Debug.Log("미흡");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
