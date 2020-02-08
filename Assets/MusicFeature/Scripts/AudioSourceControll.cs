using UnityEngine;

public class AudioSourceControll : MonoBehaviour
{
    public GameObject go_bad;
    public GameObject go_good;
    public AudioSource go_hall;
    //Value from the slider, and it converts to volume level
    float distance;    

    void Start()
    {
        //Initiate the Slider value to half way
        m_MySliderValue1 = 1f;
        m_MySliderValue2 = 1f;
    }



    float m_MySliderValue1;
    float m_MySliderValue2;
    float m_MySliderValue3;
    void OnGUI()
    {
        //Create a horizontal Slider that controls volume levels. Its highest value is 1 and lowest is 0
        GUI.HorizontalSlider(new Rect(25, 25, 200, 60), m_MySliderValue1, 0.0F, 1.0F);
        GUI.HorizontalSlider(new Rect(25, 70, 200, 60), m_MySliderValue2, 0.0F, 1.0F);
        GUI.HorizontalSlider(new Rect(25, 110, 200, 60), m_MySliderValue3, 0.0F, 1.0F);

        //Makes the volume of the Audio match the Slider value
        m_MySliderValue1 = go_bad.GetComponent<AudioSource>().volume;
        m_MySliderValue2 = go_good.GetComponent<AudioSource>().volume;
        m_MySliderValue3 = go_hall.GetComponent<AudioSource>().volume;
    }
}
