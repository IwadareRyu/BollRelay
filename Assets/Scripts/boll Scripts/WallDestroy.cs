using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    public float m_deadtime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, m_deadtime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
