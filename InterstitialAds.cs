using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InterstitialAds : MonoBehaviour
{
    private InterstitialAd Interstitial;
    string InterstitialId;

    void Start()
    {
        RequestInterstitial();
    } 
    public void ShowInterstitial()
    {
        if (this.Interstitial.IsLoaded())
        {
            Interstitial.Show();
        }
        else
        {
            Debug.Log("Inerstitial Ad is not ready yet");
        }
    }
    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        InterstitialId = "AdmobCode";
#elif UNITY_IPHONE
        bannerId = "AdmobCode";
#else
        bannerId = null;
#endif

        // Clean up interstitial ad before creating a new one.
        if (this.Interstitial != null)
            this.Interstitial.Destroy();

        // Create an interstitial.
        this.Interstitial = new InterstitialAd(InterstitialId);

        // Load an interstitial ad.
        this.Interstitial.LoadAd(this.CreateAdRequest());


    }
    private AdRequest CreateAdRequest()
    {
        return new AdRequest.Builder().Build();
    }
}
