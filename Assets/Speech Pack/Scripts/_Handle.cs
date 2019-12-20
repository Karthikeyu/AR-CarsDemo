using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

//Custom 8
public partial class Wit3D : MonoBehaviour {

	public Text myHandleTextBox;
	private bool actionFound = false;

	void Handle (string jsonString) {
		
		if (jsonString != null) {

            Debug.Log("reached1");
			RootObject theAction = new RootObject ();
			Newtonsoft.Json.JsonConvert.PopulateObject (jsonString, theAction);

			if (theAction.entities.open != null) {
				foreach (Open aPart in theAction.entities.open) {
					Debug.Log (aPart.value);
                    if (theAction._text.Contains("open"))
                        { 
                        if(theAction._text.Contains("door"))
                            carController.instance.triggerAnimation("openDriversDoor");
                    else if (theAction._text.Contains("trunk"))
                    {
                        carController.instance.triggerAnimation("openTrunk");
                    }
                    else if (theAction._text.Contains("bonnet"))
                    {
                        carController.instance.triggerAnimation("openBonnet");
                    }
                        myHandleTextBox.text = aPart.value + " is opened !";
                        actionFound = true;
				}
			}
           }
            if (theAction.entities.close != null)
            {
                foreach (Close aPart in theAction.entities.close)
                {
                    Debug.Log(aPart.value);
                    if (theAction._text.Contains("close"))
                    {
                        if (theAction._text.Contains("door"))
                            carController.instance.triggerAnimation("closeDriversDoor");
                        else if (theAction._text.Contains("trunk"))
                        {
                            carController.instance.triggerAnimation("closeTrunk");
                        }
                        else if (theAction._text.Contains("bonnet"))
                        {
                            carController.instance.triggerAnimation("closeBonnet");
                        }
                        myHandleTextBox.text = aPart.value + " is closed !";
                        actionFound = true;
                    } 
                }
            }
            if (theAction.entities.start != null)
            {
                foreach (Start aPart in theAction.entities.start)
                {
                    Debug.Log(aPart.value);
                    carController.instance.playAudio();
                    myHandleTextBox.text = aPart.value + " is started !";
                    actionFound = true;
                }
            }
            if (theAction.entities.stop != null)
            {
                foreach (Stop aPart in theAction.entities.stop)
                {
                    Debug.Log(aPart.value);
                    Debug.Log(gameContoller.currentSelectedCar);
                    carController.instance.stopAudio();
                    myHandleTextBox.text = aPart.value + " is stopped !";
                    actionFound = true;
                }
            }

            if (theAction.entities.change != null)
            {
                foreach (Change aPart in theAction.entities.change)
                {
                    Debug.Log(aPart.value);
                    // carController.instance.stopAudio();
                    Debug.Log("Color is changing");
                    if (theAction._text.Contains("change") | theAction._text.Contains("color"))
                    {
                        Debug.Log("Color is changed");
                        colourSwitcher.instance.colours(aPart.value);
                    }
                    myHandleTextBox.text = "color is changed to " + aPart.value;
                    actionFound = true;
                }
            }

            if (!actionFound) {
				myHandleTextBox.text = "Request unknown, please ask a different way.";
			} else {
				actionFound = false;
			}

 		}//END OF IF

 	}//END OF HANDLE VOID

}//END OF CLASS
	

//Custom 9
public class Open {
	public bool suggested { get; set; }
	public double confidence { get; set; }
	public string value { get; set; }
	public string type { get; set; }
}

public class Start
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}

public class Stop
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}

public class Close {
	public bool suggested { get; set; }
	public double confidence { get; set; }
	public string value { get; set; }
	public string type { get; set; }
}

public class Change
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}

public class Entities {
	public List<Open> open { get; set; }
	public List<Close> close { get; set; }
    public List<Start> start { get; set; }
    public List<Stop> stop { get; set; }
    public List<Change> change { get; set; }
}

public class RootObject {
	public string _text { get; set; }
	public Entities entities { get; set; }
	public string msg_id { get; set; }
}