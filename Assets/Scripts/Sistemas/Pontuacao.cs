using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Text ExibirPontos;
    public static int pontos;

    void Start()
    {
        pontos = 0;
    }

    private void Update()
    {
        StartCoroutine(Aguardar());
        ExibirPontos.text = pontos++.ToString();
    }

    IEnumerator Aguardar()
    {

        yield return new WaitForSeconds(1);

    }
}
