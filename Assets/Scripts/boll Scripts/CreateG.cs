using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateG : MonoBehaviour
{
    [SerializeField] GameObject m_groundUD;
    [SerializeField] GameObject m_groundRL;
    //[SerializeField] GameObject m_groundT;
    [SerializeField] Transform m_mazzleD;
    [SerializeField] Transform m_mazzleU;
    [SerializeField] Transform m_mazzleL;
    //[SerializeField] Transform m_mazzleR;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Down")&& count == 0)
        {
            Instantiate(m_groundUD, m_mazzleD.position,this.transform.rotation);
            count = 1;
        }
        else if (Input.GetButtonDown("Up") && count == 0)
        {
            Instantiate(m_groundUD, m_mazzleU.position, this.transform.rotation);
            count = 1;
        }
        else if (Input.GetButtonDown("Left") && count == 0)
        {
            Instantiate(m_groundRL, m_mazzleL.position, this.transform.rotation);
            count = 1;
        }
       /* else if (Input.GetButtonDown("Right") && count == 0)
        {
            Instantiate(m_groundT, m_mazzleL.position, this.transform.rotation);
            count = 1;
        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        count = 0;
    }
}
