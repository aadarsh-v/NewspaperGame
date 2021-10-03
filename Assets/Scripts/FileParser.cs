using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileParser : MonoBehaviour
{

    string[] lines;
    ClickableText[] clickableLines;

    int TotalLines(string filePath)
    {
        StreamReader r = new StreamReader(filePath);
        int i = 0;
        while (r.ReadLine() != null) { i++; }
        return i;
    }

    public string[] ParseText(string filePath)
    {
        int totalLines = TotalLines(filePath);
        StreamReader reader = new StreamReader(filePath);
        string line;

        lines = new string[totalLines];
        clickableLines = new ClickableText[totalLines];

        for (int i = 0; i < totalLines; ++i)
        {
            line = reader.ReadLine();
            char[] arr;
            arr = line.ToCharArray(0, 1);
            if (arr[0] == '|')
                clickableLines[i] = new ClickableText(line);
            else
                lines[i] = line;
        }

        return lines;
    }

    public ClickableText[] ParseInteractable()
    {
        return clickableLines;
    }
}
