using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audios : MonoBehaviour
{
    [SerializeField] Sprite[] musicSprite;
    [SerializeField] Sprite[] soundSprite;
    [SerializeField] Image music, audio_;
    public gamemanager audios = new gamemanager();
    bool isMusic = false, isSound = false;

    public void MusicManage(){
        audios.sources[4].Play();
        isMusic = !isMusic;
        if(isMusic){
            audios.backgroundAudio.Play();
            audios.backgroundAudio.mute = true;
            music.sprite = musicSprite[1];
        }else if(!isMusic){
            audios.backgroundAudio.Play();
            audios.backgroundAudio.mute = false;
            music.sprite = musicSprite[0];
        }
    } 

        public void AudiosManage(){
            audios.sources[4].Play();
        isSound = !isSound;
        if(isSound){
            for(int i = 0; i<audios.sources.Count; i++){
                audios.sources[i].Play();
                audios.sources[i].mute = true;
                audio_.sprite = soundSprite[1];
            }

        }else if(!isSound){
            for(int i = 0; i<audios.sources.Count; i++){
                audios.sources[i].Play();
                audios.sources[i].mute = false;
                audio_.sprite = soundSprite[0];
            }
        }
    } 
}
