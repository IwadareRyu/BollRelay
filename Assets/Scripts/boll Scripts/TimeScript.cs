using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public bool m_gamestart;
    bool m_isgameclear;
    [SerializeField] Text m_timetext;
    [SerializeField] Text m_creartimetext;
    [SerializeField] GameObject m_Button;
    public float m_timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (m_gamestart == false)
        {
            print("");
            return;
        }

        if (m_isgameclear == false)
        {
            print("Call");
            m_timer += Time.deltaTime;
            m_timetext.text = m_timer.ToString("F2");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "BallTag")
        {
            m_isgameclear = true;
            m_creartimetext.text = m_timetext.text;
            m_Button.gameObject.SetActive(true);
        }
    }
}
