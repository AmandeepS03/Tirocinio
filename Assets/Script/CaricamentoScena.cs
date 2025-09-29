using UnityEngine;

public class CaricamentoScena : MonoBehaviour
{
    public GameObject plank;
    public GameObject bridge;
    public GameObject wallAngels;
    public GameObject catCow;
    public GameObject birdDog;

    //public Camera cameraWA;

    void Start()
    {
        Camera cameraWA = GameObject.Find("CameraWA").GetComponent<Camera>();
       
        GameObject plank = GameObject.Find("Plank");
        GameObject bridge = GameObject.Find("Bridge");
        GameObject wallAngels = GameObject.Find("WallAngels");
        GameObject catCow = GameObject.Find("CatCow");
        GameObject birdDog = GameObject.Find("BirdDog");
        
         // Disattivo tutto all'inizio
        cameraWA.gameObject.SetActive(false);
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
                if (Camera.main != null)
                    Camera.main.gameObject.SetActive(false);
                // if (cameraWA != null)
                cameraWA.gameObject.SetActive(true);
                wallAngels.SetActive(true);
                break;
            case 4: catCow.SetActive(true); break;
            case 5: birdDog.SetActive(true); break;
        }
    }
}
