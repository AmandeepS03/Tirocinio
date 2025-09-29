using UnityEngine;

public class CaricamentoScena : MonoBehaviour
{
   

    void Start()
    {
        Camera cameraMain = GameObject.Find("Camera").GetComponent<Camera>();
        Camera cameraWA = GameObject.Find("CameraWA").GetComponent<Camera>();

        GameObject canvasWA = GameObject.Find("CanvasWA");
    
        GameObject plank = GameObject.Find("Plank");
        GameObject bridge = GameObject.Find("Bridge");
        GameObject wallAngels = GameObject.Find("WallAngels");
        GameObject catCow = GameObject.Find("CatCow");
        GameObject birdDog = GameObject.Find("BirdDog");
        
         // Disattivo tutto all'inizio
        cameraWA.gameObject.SetActive(false);
        canvasWA.gameObject.SetActive(false);
        plank.SetActive(false);
        bridge.SetActive(false);
        wallAngels.SetActive(false);
        catCow.SetActive(false);
        birdDog.SetActive(false);
       // if (cameraWA != null)
        // cameraWA.gameObject.SetActive(false);

        // Attivo solo quello selezionato
        switch (SelezioneEsercizio.esercizioSelezionato)
        {
            case 1: plank.SetActive(true); break;
            case 2: bridge.SetActive(true); break;
            case 3:
                
                cameraMain.gameObject.SetActive(false);
                cameraWA.gameObject.SetActive(true);
                canvasWA.gameObject.SetActive(true);
                wallAngels.SetActive(true);
                break;
            case 4: catCow.SetActive(true); break;
            case 5: birdDog.SetActive(true); break;
        }
    }
}
