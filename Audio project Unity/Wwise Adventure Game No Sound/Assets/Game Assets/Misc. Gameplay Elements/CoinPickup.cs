////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour {

    public AudioClip[] coinpicksound;
    public bool playSpawnSoundAtSpawn = true;

	void Start(){
        AudioSource audioSource = PlayerManager.Instance.player.GetComponent<AudioSource>();
        if (playSpawnSoundAtSpawn){
            // HINT: You might want to play the Coin pickup sound here
            audioSource.PlayOneShot(coinpicksound[0], 0.75f);
        }
	}

	public void AddCoinToCoinHandler(){
		InteractionManager.SetCanInteract(this.gameObject, false);
		GameManager.Instance.coinHandler.AddCoin ();
        //Destroy (gameObject, 0.1f); //TODO: Pool instead?
    }
}
