using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] GameObject ball;
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
        if (collision.gameObject.tag == "Bar")
        {
            Debug.Log("çÏìÆÇµÇƒÇ‹Ç∑ÅH");
            ball.gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
