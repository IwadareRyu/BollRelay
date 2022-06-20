using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetButtonDown("Start"))
        {
            AudioSource audio = this.gameObject.GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Play();
            }
            Invoke("Main", 0.5f);
        }
    }
    public void Main()
    {
        SceneManager.LoadScene("BollRelayRace");
    }
}
