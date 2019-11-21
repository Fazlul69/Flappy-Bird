using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEngine : MonoBehaviour
{
    
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
       
            rigid.velocity = new Vector2(-2, 0);
        
    }
}
