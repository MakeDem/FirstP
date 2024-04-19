using UnityEngine;


public class FirstScript6 : MonoBehaviour
{

    public int score;

    // Use this for initialization
    void Start () {

        if(score <= 0){
            //execute if condition is true
            print ("Game Over");

        }

        else if(score > 0 && score < 10){
            print ("Level 1");

        }

        else if (score > 10){

            print ("Level 2");

        }

        else{

            print ("Game Running");

        }

    }

    //Update is called once per frame
    void Update () {


        //if(score <= 0){
        //    //execute if condition is true
        //    print ("Game Over");

        //}

    }




}