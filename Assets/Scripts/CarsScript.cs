using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsScript : MonoBehaviour
{
    public GameObject[] carLists;
    private int carNumber = 0;
    Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        carLists = new GameObject[transform.childCount];

        for (int i = 0; i < carLists.Length; i++)
        {
            carLists[i] = transform.GetChild(i).gameObject;
            carLists[i].SetActive(false);

            if (i == 0)
            {
                carLists[i].SetActive(true);
                
            }
        }
    }

    

    public void toggleCars(string buttonName)
    {
        carLists[carNumber].SetActive(false);

        if(buttonName == "left")
        {

            if (carNumber > 0 && carNumber < carLists.Length)
                carNumber--;
            else
                carNumber = carLists.Length - 1;

        }else if(buttonName == "right")
        {
            if (carNumber >= 0 && carNumber < carLists.Length-1)
                carNumber++;
            else
                carNumber = 0;
        }
        gameContoller.currentSelectedCar = carLists[carNumber].name;
        Debug.Log(gameContoller.currentSelectedCar);
        carLists[carNumber].SetActive(true);

    }
}
