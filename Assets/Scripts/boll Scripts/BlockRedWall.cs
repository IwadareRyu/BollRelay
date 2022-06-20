using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRedWall : MonoBehaviour
{
    [SerializeField] GameObject redwall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter OnCollisionEnter2D."); // 関数が呼び出されたら Console にログを出力する

        // 衝突相手がボールだったら自分自身を破棄する
        if (collision.gameObject.tag == "BallTag")
        {
            Destroy(redwall);
            Destroy(this.gameObject);
        }
    }
}
