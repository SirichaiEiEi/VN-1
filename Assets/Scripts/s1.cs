using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s1 : MonoBehaviour
{
    public TextAsset textFile;
    string[] line = new string[12];
    string[] names = { "", "Fahsai" };
    Text textDisplay;
    int currentLine = 0;

    void Start()
    {
        string allText = textFile.text;
        line = allText.Split("\n");
        textDisplay = GameObject.Find("Text").GetComponent<Text>();
        displayText();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentLine++;
            displayText();
        }
    }

    void displayText()
    {        
        string[] tmp = new string[2];
        tmp = line[currentLine].Split(":");
        int cNumber = int.Parse(tmp[0]);
        string txt = "";
        if (cNumber > 0) txt = names[cNumber] + ": " + tmp[1];
        else txt = tmp[1];
        textDisplay.text = txt;
    }
}
