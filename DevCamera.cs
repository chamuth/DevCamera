using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevCamera : MonoBehaviour {

    public GameObject MainUI;
    public GameObject JackalCamera;
    public float FPSBoost = 25f;

    bool _photoMode = false;

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3))
        {
            // Enter the photo mode
            TogglePhotoMode();
        }

        if (_photoMode)
        {
            var translateSpeed = 10f;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                translateSpeed = 50f;
            }

            // Positioning through WASD
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Time.fixedDeltaTime * translateSpeed * Vector3.forward);
            } 

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Time.fixedDeltaTime * translateSpeed * -Vector3.forward);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Time.fixedDeltaTime * translateSpeed * -Vector3.right);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Time.fixedDeltaTime * translateSpeed * Vector3.right);
            }
            
            // Rotate camera
            transform.Rotate(new Vector3(FPSBoost * Time.fixedDeltaTime * -Input.GetAxis("Mouse Y"), FPSBoost * Time.fixedDeltaTime * Input.GetAxis("Mouse X")));

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (!System.IO.Directory.Exists("Screenshots"))
                    System.IO.Directory.CreateDirectory("Screenshots");

                ScreenCapture.CaptureScreenshot("Screenshots/" + System.IO.Directory.GetFiles("Screenshots").Length.ToString() + ".png", 4);
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                GetComponent<Camera>().orthographic = !GetComponent<Camera>().orthographic;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                GetComponent<Camera>().fieldOfView = 60f;
            }

            GetComponent<Camera>().fieldOfView += (Input.mouseScrollDelta.y);
        }
    }

    void Start()
    {
        GetComponent<Camera>().enabled = false;
    }

    void TogglePhotoMode()
    {
        if (!_photoMode)
        {
            // Stop the time
            Time.timeScale = 0;
            _photoMode = true;
            // Enable the camera
            GetComponent<Camera>().enabled = true;
            // Disable the UI
            MainUI.SetActive(false);
            // Set the location of the camera
            transform.position = JackalCamera.transform.position;
            transform.rotation = JackalCamera.transform.rotation;

            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            // Start the time
            Time.timeScale = 1;
            _photoMode = false;
            // Disable the camera
            GetComponent<Camera>().enabled = false;
            // Enable the UI
            MainUI.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
        }
    }
}
