using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
public class gameContoller : MonoBehaviour
{
    public static string currentSelectedCar = "BlueLambo";
   // bool flash = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void quit()
    {
        Application.Quit();
    }

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

   /* public void toggleFlash()
    {
        if(flash == false)
        {
            flash = true;
            CameraDevice.Instance.SetFlashTorchMode(true);
        }else if(flash == true)
        {
            flash = false;
            CameraDevice.Instance.SetFlashTorchMode(false);

        }

    }*/
}
