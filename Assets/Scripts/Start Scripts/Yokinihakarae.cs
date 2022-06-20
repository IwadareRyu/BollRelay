using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokinihakarae : MonoBehaviour
{
    float m_timer;
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject BGM;
    [SerializeField] GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_timer += Time.deltaTime;
        if(m_timer > 5.0f)
        {
            text1.gameObject.SetActive(true);
            text2.gameObject.SetActive(true);
        }
        if(m_timer > 6.0f)
        {
            BGM.gameObject.SetActive(true);
            start.gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
