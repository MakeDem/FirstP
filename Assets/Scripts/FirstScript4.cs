using UnityEngine;


public class FirstScript4 : MonoBehaviour
{

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        //TestFunction();
        //print("Shoot");
        //print("Destroy");
        //print("Move");
        //transform.Translate(speed, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestFunction()
    {
        print("Shoot");
        print("Destroy");
        print("Move");
        transform.Translate(speed, 0, 0);
        
    }
}
