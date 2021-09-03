using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void ToggleBgmMute(bool on)
    {
        audioMixer.SetFloat("BgmVolume", on ? 0 : -80);
    }
    public void ToggleSfxMute(bool on)
    {
        audioMixer.SetFloat("SfxVolume", on ? 0 : -80);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

}
