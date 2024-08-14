using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class ScreensController : MonoBehaviour
{
    public Canvas canvas;
    public GameObject[] screens;
    public int indexActualScreen = 0;

    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        GameObject screen = Instantiate(screens[indexActualScreen], new Vector3(0, 0, 0), Quaternion.identity);
        screen.transform.SetParent(canvas.transform);
        screen.transform.localScale = new Vector3(1, 1, 1);
    }
    public void callNextScreen(int indexNextScreen)
    {
        Destroy(screens[indexActualScreen]);
        GameObject nextScreen = Instantiate(screens[indexNextScreen], new Vector3(0, 0, 0), Quaternion.identity);
        nextScreen.transform.SetParent(canvas.transform);
        nextScreen.transform.localScale = new Vector3(1, 1, 1);

        indexActualScreen = indexNextScreen;
    }
}
