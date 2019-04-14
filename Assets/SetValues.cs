using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetValues : MonoBehaviour {

    public Text TechNumber;
    public Text SciNumber;
    public Text Money;
    public Text ModeText;
	
	// Update is called once per frame
	void Update () {
        TechNumber.text = Data.Tech.ToString();
        SciNumber.text = Data.Sci.ToString();
        Money.text = Data.Money.ToString();
        ModeText.text = Data.Mode;
	}
}
