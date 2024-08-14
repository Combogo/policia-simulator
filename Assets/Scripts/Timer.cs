using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public GameObject game;

    public Slider timerJogo;
    public GameObject objectTimer;
    public float tempoAtual;
    void Start()
    {
        objectTimer = GameObject.Find("SliderTimer");
        objectTimer.SetActive(false);
        tempoAtual = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(tempoAtual == 0)
        {
            StopCoroutine(TimerSlider());
            //ConversationManager.Instance.OptionSelected(m_node as OptionNode);
        }
    }
    public void clicaAGora()
    {
        objectTimer.SetActive(true);
        StartCoroutine(TimerSlider());
        //game.SetActive(true);
    }

    IEnumerator TimerSlider()
    {
        while (tempoAtual > 0)
        {
            yield return new WaitForSeconds(1);
            tempoAtual--;
            timerJogo.value = tempoAtual;
        }
        
    }
}
