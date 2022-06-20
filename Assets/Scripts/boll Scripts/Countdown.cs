using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] float m_timer;
    [SerializeField] GameObject m_3;
    [SerializeField] GameObject m_2;
    [SerializeField] GameObject m_1;
    [SerializeField] GameObject m_g;
    [SerializeField] GameObject m_o;
    [SerializeField] GameObject m_ball;
    [SerializeField] GameObject m_block;
    [SerializeField] GameObject m_bar1;
    [SerializeField] GameObject m_bar2;
    [SerializeField] GameObject m_yazirusi;
    [SerializeField] TimeScript m_time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_timer += Time.deltaTime;
        if(m_timer < 1)
        {
            m_3.gameObject.SetActive(true);
        }
        else if(m_timer < 2)
        {
            m_2.gameObject.SetActive(true);
            m_3.gameObject.SetActive(false);
        }
        else if(m_timer < 3)
        {
            m_1.gameObject.SetActive(true);
            m_2.gameObject.SetActive(false);
        }
        else if(m_timer < 4)
        {
            m_time.m_gamestart = true;
            m_1.gameObject.SetActive(false);
            m_g.gameObject.SetActive(true); 
            m_o.gameObject.SetActive(true);
            m_ball.gameObject.SetActive(true);
            m_block.gameObject.SetActive(true); 
            m_bar1.gameObject.SetActive(true); 
            m_bar2.gameObject.SetActive(true);
            m_yazirusi.gameObject.SetActive(true);
        }
        else if(m_timer < 5)
        {
            m_g.gameObject.SetActive(false);
            m_o.gameObject.SetActive(false);
            m_time.gameObject.SetActive(true);

            Destroy(this.gameObject);
        }
    }
}
