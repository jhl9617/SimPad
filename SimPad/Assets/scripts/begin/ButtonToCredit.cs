using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonToCredit : MonoBehaviour
{
    AudioSource myAudio;
    [SerializeField] AudioClip clickSound1;

    private AudioSource theaudio;
    public AudioClip jumpSound;
    public void OnClickcredit()
    {
        SceneManager.LoadScene(1);
    }

    void Start()
    {
        GetComponent<AudioSource>();

    }

    public void playSE()
    {
        myAudio.Play();
    }

}


