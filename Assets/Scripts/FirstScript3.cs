using UnityEngine;

public class FirstScript3 : MonoBehaviour

{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        //print("Car Move");
        //transform.Translate(0.1f, 0, 0);
        //transform.Translate(speed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //print("Car Move");
        transform.Translate(speed, 0, 0);
    }
}
