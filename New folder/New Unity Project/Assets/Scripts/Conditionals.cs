using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    int time = 304;
    public string weather = "Clear";
    bool isStopLightRed = true;
    public float gpa = 3.25f;
    double temperature = 101.45d;



    // Start is called before the first frame update
    void Start()
    {
        //Check Time
        if(time >= 200)
        {
            Debug.Log("Rise and Shine!");
        }
        else
        {
            Debug.Log("It's too early go back to bed!");
        }

        // Check Stop Light
        if(isStopLightRed == true)
            {
                Debug.Log("Don't go, the light is red!");
            }
            else
            {
                Debug.Log("The light is green, you are good to go!");
            }

        // Check Temperature
        if(temperature == 96.35d)
            {
                Debug.Log("It's a nice day outside");
            }
        else if(temperature < 96.35d)
             {
                 Debug.Log("It's a rather chilly day outside");
             }
        else if(temperature > 96.35d)
            {
                Debug.Log("It's really hot outside!");
            }

        

        /*

        if(conditional_01)
        {
            //If condition_01 is true run this code
        }
        else if(conditional_02)
        {
            //If condition_02 is true run this code
        }
        else
        {
            //If no other conditions are true run this code
        }

        */

    }
    // Update is called once per frame
    void Update()
    {
         //Check Weather
        if(weather == "Cloudy")
            {
               Debug.Log("It is cloudy outside");
            }
        else if (weather == "Raining")
            {
                Debug.Log("It is raining outside!");
            }
        else if (weather == "Clear")
            {
                Debug.Log("It is a beautiful day outside!");
            }
        else if (weather == "Thunder/Lightning")
            {
                Debug.Log("There is thunder and lightning outside, stay indoors!!!");
            }
        else if (weather == "Snowing")
            {
                Debug.Log("It is snowing outside, bundle up it is cold");
            }
        else
            {
                Debug.Log("Do what you want, it's a day");
            }

        //Check GPA
        if(gpa >= 3.5f)
            {
                Debug.Log("Your grades are looking great!");
            }
        else if(gpa < 3.5f)
            {
                Debug.Log("You should get your grades up!");
            }
    }
}
