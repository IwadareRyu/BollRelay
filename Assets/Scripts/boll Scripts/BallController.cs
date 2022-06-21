using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ボールを制御するコンポーネント。ボールのオブジェクトに追加して使う。
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    /// <summary>ボールが最初に動く方向</summary>
    [SerializeField] Vector2 m_powerDirection = Vector2.up + Vector2.right;
    /// <summary>ボールを最初に動かす力の大きさ</summary>
    [SerializeField] float m_powerScale = 5f;
    Rigidbody2D m_rb2d;
    [SerializeField] GameObject Effect;
    [SerializeField] float m_maxSpeed = 3f;
    Vector3 m_initialposition;
    [SerializeField] GameObject m_effect;
    [SerializeField] TimeScript m_time;
    [SerializeField] GameObject m_plus;
    [SerializeField] GameObject m_kasan;

    void Start()
    {
        m_rb2d = GetComponent<Rigidbody2D>();
        // ボールを動かす
        m_initialposition = this.transform.position;
        Push();
    }

    void Update()
    {
        if (m_rb2d.velocity.magnitude != m_maxSpeed)
        {
            m_rb2d.velocity = m_rb2d.velocity.normalized * m_maxSpeed;
        }
        if(this.transform.position.y < -6f)
        {
            m_time.m_timer += 10f;
            Instantiate(m_plus, m_kasan.transform.position, this.transform.rotation);
            this.transform.position = this.m_initialposition;
            Push();
            Push();
        }

    }

    /// <summary>
    /// ボールに力を加える
    /// </summary>
    public void Push()
    {
        m_rb2d.AddForce(m_powerDirection.normalized * m_powerScale, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if(audio != null)
        {
            audio.Play();
        }
        Instantiate(Effect, this.transform.position, this.transform.rotation);
        if(collision.gameObject.tag == "Atari")
        {
           // Instantiate(m_effect, this.transform.position, this.transform.rotation);
            Instantiate(m_effect, collision.contacts[0].point, Quaternion.identity);
        }
    }
}