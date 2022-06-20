using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leftmove : MonoBehaviour
{
    [SerializeField] float m_speed = 2f;
    [SerializeField] float m_lifetime = 120f;

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x < m_lifetime)
        {
            Destroy(this.gameObject);
        }
        this.transform.Translate(Vector2.left * m_speed * Time.deltaTime);
    }
}
