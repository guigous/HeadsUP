using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class HUDManager : MonoBehaviour
{
    public int score;
    public GameObject HUD;
    public Slider scoreSlider1;
    public Slider scoreSlider2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnSliderValueChanged(int value)
    {

       
    }
    public void SetScore(int value)
    {
        score += value;
       

    }

}
