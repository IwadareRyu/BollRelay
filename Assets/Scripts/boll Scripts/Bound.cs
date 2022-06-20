using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{
   /* [SerializeField] Vector2 m_powerDirection = Vector2.up;
    [SerializeField] float m_powerScale = 5f;
    Rigidbody2D m_rb2d;*/
   // [SerializeField] float m_lowScale = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       /* if(collision.gameObject.tag == "Ground")
        {*/
    //        m_rb2d.AddForce(m_powerDirection.normalized * m_powerScale, ForceMode2D.Impulse);
        //}
       /* else if(collision.gameObject.tag == "LowGround")
        {
            m_rb2d.AddForce(m_powerDirection.normalized * m_lowScale, ForceMode2D.Impulse);
        }*/
    }
}
