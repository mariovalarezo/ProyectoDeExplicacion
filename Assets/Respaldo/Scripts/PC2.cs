using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC2 : MonoBehaviour
{

    Vector3 punto1 = new Vector3(3,0,4);



    CharacterController characterController;

    Vector3 move = Vector3.zero;
    float velocidad = 2f;

    float moveMosuseH = 0;
    float moveMosuseV = 0 ;


    float velMosuseH = 2f;
    float velMosuseV = 1.8f;




    [SerializeField] Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        //Primero

        // Debug.Log("Hola Mundo en Start");

        //Segundo
        //gameObject.transform.position = punto1;
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(transform.TransformDirection(move) * Time.deltaTime * velocidad);

        moveMosuseH = velMosuseH * Input.GetAxis("Mouse X"); 
        moveMosuseV = velMosuseV * Input.GetAxis("Mouse Y");

        // camera.transform.Rotate(moveMosuseH, moveMosuseV,0);


        transform.Rotate(0, moveMosuseH, 0);
        camera.transform.Rotate(moveMosuseV,0,0);
        //Tecero
        /*
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
            gameObject.transform.position.z + 0.1f  );
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
            gameObject.transform.position.z - 0.1f);
        }
        */




    }

    
}
