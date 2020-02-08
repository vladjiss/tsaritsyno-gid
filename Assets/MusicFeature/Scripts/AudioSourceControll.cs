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
        m_MySliderValue1 = 0.5f;
        m_MySliderValue2 = 0.5f;
    }

    //void Update()
    //{
    //    float d_bad = Vector3.Distance(transform.position, go_bad.GetComponent<Transform>().position);
    //    float d_good = Vector3.Distance(transform.position, go_good.GetComponent<Transform>().position);
    //    //Debug.Log("BAD " + d_bad);
    //    //Debug.Log("GOOD " + d_good);
    //    if (d_bad <= d_good)
    //    {
    //        if (go_bad.GetComponent<SoundManager>().IsClose())
    //        {
    //            //Debug.Log("True for bad");
    //            if (go_good.GetComponent<SoundManager>().IsExit()) { 
    //                //Debug.Log("BAD IS EXIT");
    //                if (!go_bad.GetComponent<SoundManager>().audio_controller.isPlaying)
    //                {
    //                    go_bad.GetComponent<SoundManager>().audio_controller.Play();
    //                }
    //                else
    //                {
    //                    if (go_good.GetComponent<SoundManager>().audio_controller.isPlaying)
    //                        go_good.GetComponent<SoundManager>().audio_controller.Stop();
    //                }
    //            }
    //        }
    //        distance = d_bad;
    //    } else {
    //        if (go_good.GetComponent<SoundManager>().IsClose())
    //        {
    //            //Debug.Log("True for good");
    //            if (go_bad.GetComponent<SoundManager>().IsExit())
    //            {
    //                //Debug.Log("BAD IS EXIT");
    //                if (!go_good.GetComponent<SoundManager>().audio_controller.isPlaying)
    //                {
    //                    go_good.GetComponent<SoundManager>().audio_controller.Play();
    //                }
    //                else
    //                {
    //                    if (go_bad.GetComponent<SoundManager>().audio_controller.isPlaying)
    //                        go_bad.GetComponent<SoundManager>().audio_controller.Stop();
    //                }
    //            }
    //        }
    //        distance = d_good;
    //    }
    //    Debug.Log("DIST " + distance);

    //}

    private void Update()
    {
        Debug.Log(go_good.GetComponent<AudioSource>().isPlaying + " " + go_bad.GetComponent<AudioSource>().isPlaying);
        Debug.Log(!go_good.GetComponent<AudioSource>().isPlaying && !go_bad.GetComponent<AudioSource>().isPlaying);
        if (!go_good.GetComponent<AudioSource>().isPlaying && !go_bad.GetComponent<AudioSource>().isPlaying)
        {
            if (!go_hall.isPlaying)
            {
                go_hall.volume = 1f;
                go_hall.UnPause();
                //go_hall.Play();
            }
        }

    }


    float m_MySliderValue1;
    float m_MySliderValue2;
    void OnGUI()
    {
        //Create a horizontal Slider that controls volume levels. Its highest value is 1 and lowest is 0
        GUI.HorizontalSlider(new Rect(25, 25, 200, 60), m_MySliderValue1, 0.0F, 1.0F);
        GUI.HorizontalSlider(new Rect(25, 70, 200, 60), m_MySliderValue2, 0.0F, 1.0F);
        //Makes the volume of the Audio match the Slider value
        m_MySliderValue1 = go_bad.GetComponent<AudioSource>().volume;
        m_MySliderValue2 = go_good.GetComponent<AudioSource>().volume;
    }
}
