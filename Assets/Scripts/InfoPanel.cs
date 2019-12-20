using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }


    public void playAnim()
    {
        Debug.Log("Infobutten clicked !");
        anima.Play("Infoanim");
    }

    public void closeAnim()
    {
        anima.Play("InfoanimReverse");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
