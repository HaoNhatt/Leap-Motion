using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    public GameObject sphere;
    public Leap.PhysicalHands.PhysicalHandsSlider slider;

    public void SpawnCubeObject()
    {
        Instantiate(cube, transform.position, Quaternion.identity);
    }

    public void SpawnSphereObject()
    {
        Instantiate(sphere, transform.position, Quaternion.identity);
    }

    // public void SliderSet()
    // {
    //     float value = slider.SliderValue;
    //     Debug.Log("value: " + value);
    // }
}
