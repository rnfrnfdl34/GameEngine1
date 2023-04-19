using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Rigidbody ballRd;

    public float speed = 100.0f;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ballRd = GetComponent<Rigidbody>();

        startPos = new Vector3(0.5f,0,3.45f);
        ballRd.AddForce(-speed,0f,speed*0.7f);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("WALLED").Length == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("WALLED")) {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);
            reflectVec = reflectVec.normalized;

            ballRd.AddForce(reflectVec * speed);

            Destroy(collision.gameObject);

            
        }
        else if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);
            reflectVec = reflectVec.normalized;

            ballRd.AddForce(reflectVec * speed);
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 currPos = collision.transform.position;

            Vector3 incomVec = currPos - startPos;
            Vector3 normalVec = collision.contacts[0].normal;
            Vector3 reflectVec = Vector3.Reflect(incomVec, normalVec);
            reflectVec = reflectVec.normalized;

            ballRd.AddForce(reflectVec * speed);
        }

        startPos = transform.position;

    }

}
