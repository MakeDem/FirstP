using UnityEngine;

//using UnityEngine.UI;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("Unity Is Running");
        //print("My first script is running");
        print("Start function Getting Called");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        print("Inside OnEnable");
    }

    void OnDisable()
    {
        print("Inside OnDisable");
    }
    
}
