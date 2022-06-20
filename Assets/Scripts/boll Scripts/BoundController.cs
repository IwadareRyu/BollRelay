using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundController : MonoBehaviour
{
    Rigidbody2D m_rb2d;
    [SerializeField] GameObject Effect;
    [SerializeField] float m_maxSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_rb2d.velocity.magnitude > m_maxSpeed)
        {
            m_rb2d.velocity = m_rb2d.velocity.normalized * m_maxSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }
        Instantiate(Effect, this.transform.position, this.transform.rotation);
    }
}
