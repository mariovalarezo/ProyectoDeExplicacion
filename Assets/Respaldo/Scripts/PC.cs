using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    public float numero = 1;
    CharacterController characterController;
    public float force = 150;
    float gravity = 20;
    Vector3 move = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola esto se ejecutara 1 vez");
        characterController = gameObject.GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical") *2f * Time.deltaTime);

        move.y -= gravity * Time.deltaTime;
        characterController.Move(move);
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Hola esto se ejecutara 1 vez cuando pulse W");



            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
               gameObject.transform.position.z+1);

           
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Hola esto se ejecutara 1 vez cuando pulse S");

        }



    }
}
