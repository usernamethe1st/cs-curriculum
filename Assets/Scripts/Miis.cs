using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miis : MonoBehaviour
{
    //public GameObject explosioneffect;
    public float luck = 10f;


    public Transform target;
    public Rigidbody2D rd;

    public float rotateSpeed = 200f;

    // Start is called before the first frame update
    //void Start()
    //{
      // target = .gameObject.CompareTag("Player")Transform;
    //}

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = (Vector2)target.position - rd.position;

        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rd.angularVelocity = -rotateAmount * rotateSpeed;
       // rd.GetComponent<Rigidbody2D>();

       // rd.velocity = transform.up * luck;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
         //   Instantiate(explosioneffect,transform.position,transform.rotation);
        }
        Destroy(gameObject);
    }
}