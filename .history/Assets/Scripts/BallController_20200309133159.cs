using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int force;
    RigidBody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<RigidBody2D>();
        Vector2 arah = new Vector2(2,0).normalized;
        rigid.AddForce(arah*force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
