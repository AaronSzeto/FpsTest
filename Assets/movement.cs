using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float player_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement = Input.GetAxis("Vertical") * player_speed;
        transform.Translate(Vector3.forward * movement, Space.Self);
    }
    private void Update()
    {

    }
}
