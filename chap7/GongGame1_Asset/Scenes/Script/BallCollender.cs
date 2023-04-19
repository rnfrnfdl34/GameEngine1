using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollender : MonoBehaviour
{
    
    private Rigidbody ballRd;
    
    [SerializeField]
    public float speed = 50.0f;
    Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {   
        float a = Random.Range(-4,4);
        float b = Random.Range(-4,4);
        ballRd = GetComponent<Rigidbody>();
        startPos = new Vector3(a, 0, b);
        transform.position = startPos;
        ballRd.AddForce(-speed, 0f, speed * 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("WALL")){
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec , normalVec);
            reflectVec = reflectVec.normalized;

            ballRd.AddForce(reflectVec*speed);
        }
        startPos = transform.position;
    }
}
