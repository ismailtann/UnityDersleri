using UnityEngine;
using UnityEngine.UI;

public class SesKontrol : MonoBehaviour
{
    public Slider sesSlider; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (sesSlider != null)
        {
            sesSlider.value = AudioListener.volume; // Başlangıçta slider'ı mevcut ses seviyesine ayarla

        }
    }

    public void SesiAyarla(float yeniSes)
    {
        AudioListener.volume = yeniSes; // Ses seviyesini ayarla
    }


    public void SesiKapatAc()
    {
        if(AudioListener.volume > 0)
        {
            AudioListener.volume = 0;
            if (sesSlider != null) sesSlider.value =0;
        }
        else
        {
            AudioListener.volume = 1;
            if (sesSlider != null) sesSlider.value = 1;
        }
    }

}
