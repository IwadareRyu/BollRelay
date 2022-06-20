using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour
{
    [SerializeField] public float m_speed = 15f;
   // [SerializeField] float m_lifetime = 5f;
    Rigidbody2D rb;
    [SerializeField] GameObject m_effect;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * m_speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kabe")
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "Atari")
        {
            Instantiate(m_effect, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }

}
