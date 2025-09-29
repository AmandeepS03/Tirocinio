using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Button Plank;
    public Button Bridge;
    public Button WallAngels;
    public Button CatCow;
    public Button BirdDog;

    public string nomeScena = "scene";

    void Start()
    {
        Plank.onClick.AddListener(() => SelezionaEsercizio(1));
        Bridge.onClick.AddListener(() => SelezionaEsercizio(2));
        WallAngels.onClick.AddListener(() => SelezionaEsercizio(3));
        CatCow.onClick.AddListener(() => SelezionaEsercizio(4));
        BirdDog.onClick.AddListener(() => SelezionaEsercizio(5));
    }

    private void SelezionaEsercizio(int id)
    {
        SelezioneEsercizio.esercizioSelezionato = id;
        SceneManager.LoadScene(nomeScena);
    }
}
