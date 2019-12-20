//Video Changer

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Swapper : MonoBehaviour {

	public VideoPlayer myVideoPlayer;
	public VideoClip myVideoClip;

	void OnTriggerEnter () {
		myVideoPlayer.clip = myVideoClip;
		myVideoPlayer.Play ();

	}
}
