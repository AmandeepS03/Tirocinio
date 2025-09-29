using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public Button back;
    public string nomeScena = "Menu";
    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(BackToMenu);
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene(nomeScena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
