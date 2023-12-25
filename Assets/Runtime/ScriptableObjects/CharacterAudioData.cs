using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class AudioData
{
    public String ID;
    public AudioClip audioClip;

}

[CreateAssetMenu(menuName = "UgurcanAksak/CharacterSystem/CharacterAudioData")]
public class CharacterAudioData : ScriptableObject
{
    public List<AudioData> Data= new List<AudioData>();
    public Dictionary<string, AudioClip> CharacterAudioCollection = new Dictionary<string, AudioClip>();

    public void Awake()
    {
        for (int i = 0; i < Data.Count; i++)
        {
            CharacterAudioCollection[Data[i].ID]= Data[i].audioClip;
        }
    }
}
