using UnityEngine;

using System.Collections;

using System;

using System.IO;

 

public class LineReader : MonoBehaviour

{

    protected FileInfo theSourceFile = null;

    protected StreamReader reader = null;

    protected string text = " "; // assigned to allow first line to be read below

 

    void Start () {

        theSourceFile = new FileInfo ("random.txt");

        reader = theSourceFile.OpenText();

    }

    

    void Update () {

        if (text != null) {

            text = reader.ReadLine();

            //Console.WriteLine(text);

            print (text);

        }

    }

}