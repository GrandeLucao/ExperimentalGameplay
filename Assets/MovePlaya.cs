using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlaya : MonoBehaviour
{
    private Rigidbody2D rig;
    public float speed;

     void Start()
    {
        rig=GetComponent<Rigidbody2D>();
    }
    
     void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float movement= Input.GetAxis("Horizontal");
        float heightMove= Input.GetAxis("Vertical");
        rig.velocity=new Vector2(movement*speed, heightMove*speed);
        if(movement>0){
            transform.eulerAngles=new Vector3(0,0,0);
        }
        if(movement<0){
            transform.eulerAngles=new Vector3(0,180,0);
        }

    }

    void OnTriggerEnter2D(Collider2D coll){
        if(coll.gameObject.tag=="Button"){
            //if(Input.GetButtonDown("Fire1")){
                coll.gameObject.transform.localScale+=new Vector3(5,0,6);
            //}
        }
    }
}
