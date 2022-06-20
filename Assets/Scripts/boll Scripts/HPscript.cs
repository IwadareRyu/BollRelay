using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPscript : MonoBehaviour
{
    [SerializeField]int count = 30;
    [SerializeField] GameObject m_boss;
    [SerializeField] GameObject m_prehab;
    new AudioSource audio;
    [SerializeField] float m_interval = 3f;
    float m_timer;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        m_timer += Time.deltaTime;
        if (m_timer > m_interval)
        {
            m_timer = 0;
            Instantiate(m_prehab, this.transform.position, this.transform.rotation);
        }
        if (count < 0)
        {
            Destroy(m_boss, 1.4f);
            Destroy(this.gameObject, 1.5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BallTag")
        {
            count -= 2;
            if (audio != null)
            {
                audio.Play();
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            count--;
            /*if (audio != null)
            {
                audio.Play();
            }*/
        }
    }
}
