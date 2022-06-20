using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    [SerializeField] GameObject kabe;
    public float m_wallx;
    public float m_wally;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SecretBar")
        {
            Debug.Log("çÏìÆÇµÇƒÇ‹Ç∑ÅH");
            Instantiate(kabe, new Vector2(m_wallx, m_wally), Quaternion.identity);
        }
    }
}
