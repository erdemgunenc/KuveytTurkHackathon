using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyAR;

public class MainController : MonoBehaviour {

    public GameObject loginPanel;
    public GameObject homePanel;

    public GameObject main_camera;
    public GameObject easy_ar_object;

    public Button loginButton;
    public Button scanQRButton;

    public List<GameObject> target_images; // list of the target images that can be used in the app

    public ImageTrackerBaseBehaviour image_tracker;

    public GameObject controller;

    public bool model_alive;

    public GameObject image_targets;


    // Use this for initialization
    void Start () {

        loginPanel.SetActive(true);
        homePanel.SetActive(false);

        loginButton.onClick.AddListener(Login);
        
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Login()
    {
        loginPanel.SetActive(false);
        homePanel.SetActive(true);
        scanQRButton.onClick.AddListener(ScanQr);
    }

    void ScanQr()
    {
        homePanel.SetActive(false);
        main_camera.SetActive(false);
        easy_ar_object.SetActive(true);
        image_targets.SetActive(true);
    }



}
