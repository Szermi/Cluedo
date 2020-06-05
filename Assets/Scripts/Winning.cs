using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winning : MonoBehaviour
{
    private int chosenItem = 0;
    private int chosenPlace = 0;
    private int chosenPerson = 0;
    Color whiteColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    public void onButtonClick()
    {

        switch (chosenItem)
        {
            case 1: {
                    changeButtonColor("BottleImage");
                    break;
                }
            case 2:
                {
                    changeButtonColor("HammerImage");
                    break;
                }
            case 3:
                {
                    changeButtonColor("HacheImage");
                    break;
                }
            case 4:
                {
                    changeButtonColor("KnifeImage");
                    break;
                }
            case 5:
                {
                    changeButtonColor("ShovelImage");
                    break;
                }
            case 6:
                {
                    changeButtonColor("RopeImage");
                    break;
                }
            default: break;
        }


        switch (name)
        {
            case "BottleImage": { chosenItem = 1; break; }
            case "HammerImage": { chosenItem = 2; break; }
            case "HacheImage": { chosenItem = 3; break; }
            case "KnifeImage": { chosenItem = 4; break; }
            case "ShovelImage": { chosenItem = 5; break; }
            case "RopeImage": { chosenItem = 6; break; }
        }


        print(name + " " + chosenItem);
    }

    private void changeButtonColor(string name)
    {
        ColorBlock gameObject = GameObject.Find(name).GetComponent<Button>().colors;
        gameObject.selectedColor = whiteColor;

    }
}
