using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGD : MonoBehaviour
{
    [SerializeField] GameObject m_groundUD;
    int count = 0;
    [SerializeField] Transform m_mazzleD;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Down") && count == 0)
        {
            Instantiate(m_groundUD, m_mazzleD.position, this.transform.rotation);
            count = 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        count = 0;
    }
}
