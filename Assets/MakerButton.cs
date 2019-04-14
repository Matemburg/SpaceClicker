using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakerButton : MonoBehaviour {

    public Text text; 

    public void Click ()
    {
        if (Data.Mode == "HR")
        {
            Data.Money++;
   
        }
        else if (Data.Mode == "LAB") {
            Data.Sci++;

        }
        else if (Data.Mode == "TECH") {
            Data.Tech++;
           
                }
    }

    private void Update()
    {
        if (Data.Mode == "HR")
        {

            text.text = "Get money from Sponsors";
        }
        else if (Data.Mode == "LAB")
        {

            text.text = "Make a Experiment";
        }
        else if (Data.Mode == "TECH")
        {

            text.text = "Test new Solutions";
        }

    }
}
