using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)==true){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)==true){
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
    }
}
