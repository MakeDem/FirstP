using UnityEngine;


public class FirstScript5 : MonoBehaviour
{

    //public int number;

    public string MyName;

    // Use this for initialization
    void Start () {

        //int returnedNumber = GiveDouble (5);

        //print (returnedNumber);

        //PrintName("Raja");
        
        PrintName (MyName);

    }

    //Update is called once per frame
    void Update () {

    }


    //int GiveDouble()

    //return (number * 2);

    int GiveDouble(int val){

        return (val * 2);

    }

    void PrintName( string name ){

        print(" My name is " + name);

    }

    
    void TestFunction(){




    }




}