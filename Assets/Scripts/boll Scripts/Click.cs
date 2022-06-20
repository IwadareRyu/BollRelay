using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public void OnClick()
    {
        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }
        Invoke("Main", 0.5f);
    }
    public void Main()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
