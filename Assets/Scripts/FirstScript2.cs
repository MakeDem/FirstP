using UnityEngine;

public class FirstScript2 : MonoBehaviour
{
    //int score = 10;
    public int score = 10;

    float speed = 2.5f;

    char character = 'A';

    //string name = "Raja";
    //string name = "Sam";
    public string name = "Sam";

    // Start is called before the first frame update
    void Start()
    {
        //print(10);
        //print(score);
        //print(speed);
        //print(character);
        //print(name);
        print("My name is: " + name);
        print("My score is: " + score);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}