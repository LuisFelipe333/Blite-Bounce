using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;

public class LogicaAds : MonoBehaviour
{
    private RewardBasedVideoAd adReward;
    private String idApp, idReward;
    [SerializeField] Button BtnReward;

    private void Start()
    {
    	idApp="ca-app-pub-2236464614602707~4752753445";
       idReward="ca-app-pub-3940256099942544/5224354917"; 
       adReward=RewardBasedVideoAd.Instance;
       MobileAds.Initialize(idApp);
       Debug.Log("empezo");
    }

//------------------------------------------------------------------------------------------------

    public void RequestRewardAd ()
	{
		AdRequest request = AdRequestBuild ();
		adReward.LoadAd (request, idReward);

		adReward.OnAdLoaded += this.HandleOnRewardedAdLoaded;
		adReward.OnAdRewarded += this.HandleOnAdRewarded;
		adReward.OnAdClosed += this.HandleOnRewardedAdClosed;
	}

	public void ShowRewardAd ()
	{
		if (adReward.IsLoaded ())
			adReward.Show ();
	}
	//events
	public void HandleOnRewardedAdLoaded (object sender, EventArgs args)
	{//ad loaded
		ShowRewardAd ();

	}

	public void HandleOnAdRewarded (object sender, EventArgs args)
	{//user finished watching ad
		EstadoJuego.estadoJuego.numeroEstrellas++;
        EstadoJuego.estadoJuego.GuardarEstrellas();
	}

	public void HandleOnRewardedAdClosed (object sender, EventArgs args)
	{//ad closed (even if not finished watching)
		BtnReward.interactable = true;

		if(Idioma.idioma.idiomaSeleccionado==0)
		BtnReward.GetComponentInChildren <Text> ().text = "AD = 1 star";
			else if(Idioma.idioma.idiomaSeleccionado==1)
			BtnReward.GetComponentInChildren <Text> ().text = "AD = 1 estrella";

		adReward.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
		adReward.OnAdRewarded -= this.HandleOnAdRewarded;
		adReward.OnAdClosed -= this.HandleOnRewardedAdClosed;
	}

	//#endregion
	

	//other functions
	//btn (more points) clicked
	public void OnGetMorePointsClicked ()
	{
		BtnReward.interactable = false;

		if(Idioma.idioma.idiomaSeleccionado==0)
		BtnReward.GetComponentInChildren <Text> ().text = "Loading...";
			else if(Idioma.idioma.idiomaSeleccionado==1)
			BtnReward.GetComponentInChildren <Text> ().text = "Cargando...";

		RequestRewardAd ();
	}

//-----------------------------------------------------------------------------

    AdRequest AdRequestBuild ()
	{
		return new AdRequest.Builder ().Build ();
	}

	void OnDestroy ()
	{
		adReward.OnAdLoaded -= this.HandleOnRewardedAdLoaded;
		adReward.OnAdRewarded -= this.HandleOnAdRewarded;
		adReward.OnAdClosed -= this.HandleOnRewardedAdClosed;
	}

//-----------------------------------------------------------------------------

    /*private RewardBasedVideoAd rewardBasedVideoAd;
 
    [SerializeField] private string adUnitId = "";

    public void Start()
    {
        rewardBasedVideoAd = RewardBasedVideoAd.Instance;
        rewardBasedVideoAd.OnAdRewarded += HandleOnAdRewarded;
        LoadRewardBasedAd();
    }
 
    public void LoadRewardBasedAd()
    { 
        rewardBasedVideoAd.LoadAd(new AdRequest.Builder().Build(), adUnitId);
    }

    public void ShowRewardBasedAd()
    {
        if (rewardBasedVideoAd.IsLoaded())
        {
            rewardBasedVideoAd.Show();
        }
        else
        {
            MonoBehaviour.print("Dude, your ad's not loaded yet.");
        }
    }
 
    public void HandleOnAdRewarded(object sender, Reward args)
    {
        EstadoJuego.estadoJuego.numeroEstrellas++;
        EstadoJuego.estadoJuego.GuardarEstrellas();
        string type = args.Type;
        double amount = args.Amount;
        print("User rewarded with: " + amount.ToString() + " " + type);
    }
        */
}