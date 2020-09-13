using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
   
    [Header("速度"),Range(0.1f,5)]
    public float speed = 2.5f;
    [Header("攻擊傷害"), Range(0.1f, 5)]
    public float attack = 2.5f;
    public Animator ani;
    public Bounds localBounds;
    public Rigidbody2D rig;
    public Transform tra;

    public void Attck()
    {




    }
    public void Move()
    {
        float v = Input.GetAxis("Horizontal");
        Vector3 pos = new Vector3(v,0,0);
        rig.MovePosition(transform.position + pos * speed);
        ani.SetFloat("跑", Mathf.Abs(v));

    }
    public void Hit()
    {




    }





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
