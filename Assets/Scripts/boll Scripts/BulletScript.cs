using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] GameObject m_bullet;
    [SerializeField] GameObject m_muzzle;
    float m_time = 0;
    bool m_loading = false;
    [SerializeField] float m_interval = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_loading)
        {
            m_time += Time.deltaTime;
        }
        if(Input.GetButtonDown("Jump") && !m_loading)
        {
            Instantiate(m_bullet, m_muzzle.transform.position, this.transform.rotation);
            m_loading = true;
        }
        if(m_time > m_interval)
        {
            m_loading = false;
            m_time = 0;
        }
    }
}
