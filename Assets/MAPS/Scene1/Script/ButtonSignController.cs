using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSignController : MonoBehaviour
{
    /*
    [SerializeField] private AudioSource soundSource_ShowButton = null;
    [SerializeField] private AudioSource soundSource_HideButton = null;
    [SerializeField] private float soundDelay_ShowButton = 0;
    [SerializeField] private float soundDelay_HideButton = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Button")
        {
            soundSource_ShowButton.PlayDelayed(soundDelay_ShowButton);
        }
    }*/

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Button")
        {
            Animator animo = other.GetComponentInChildren<Animator>();
            animo.SetTrigger("ShowButton?");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Button")
        {
            Animator animo = other.GetComponentInChildren<Animator>();
            animo.SetTrigger("HideButton?");
            //soundSource_HideButton.PlayDelayed(soundDelay_HideButton);
        }
    }
}
